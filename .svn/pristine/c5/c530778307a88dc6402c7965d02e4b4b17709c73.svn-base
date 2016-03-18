using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AgrupamientosCuentas.
	/// </summary>
	public class AgrupamientosCuentas : Agrupamientos	
	{
		
		private tsa_AgrupCuentasDataset _data = new tsa_AgrupCuentasDataset();
		private tsa_CuentasJerarquiasDataset _dataJerarquias = new tsa_CuentasJerarquiasDataset();

		public AgrupamientosCuentas()
		{

		}

		public event System.EventHandler ObjectHasChanged;
		

		public  override string  GetUIClass()
		{
			return "mz.erp.ui.controllers.tsa_Cuentas";
		}

		public override ArrayList GetFields()
		{
			return new ArrayList();
		}

		public override string GetUIClassAgrupamientos()
		{
			return "mz.erp.ui.controllers.tsa_AgrupCuentas";
		}


		public override Node getChildsNode(string key)
		{
			System.Data.DataTable table;
			string descriptionH = String.Empty;
			string keyH = String.Empty;
			string descriptionN = String.Empty;
			string keyN = String.Empty;
			Node header;
			if (key.ToUpper().Equals("RAIZ")) 
			{
                //German 20120517 - Tarea 0000329
				//table = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetNomenclaturas();
                table = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetNomenclaturasFiltrandoCampoAuxiliar6();
                //Fin German 20120517 - Tarea 0000329
				header = new Node(key, "Agrupamientos");
			}
			else
			{
				table = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetList(key);
				header = new Node(key, key);
			}

			foreach (System.Data.DataRow rowH in table.Rows) 
			{
				descriptionH = rowH["Descripcion"].ToString();
				keyH = rowH["IdNomenclatura"].ToString();
				Node child = new Node(keyH, descriptionH);
				header.AddChild(child);
			}
	
			return header;
		}
        //Cristian Tarea 00084 20120110
        public override void Agregar(String codigoCuenta)
        {
            if (this.Elementos == null)
                this.SetElementos(new CuentasViewCollection());
            
            tsa_CuentasDataset.tsa_CuentasRow row = mz.erp.businessrules.tsa_Cuentas.GetByCodigo(codigoCuenta);
            if (row != null)
            {
                CuentaView cuenta = new CuentaView();
                cuenta.Codigo = Convert.ToString(row["Codigo"]);
                cuenta.IdCuenta = Convert.ToString(row["IdCuenta"]);
                cuenta.Nombre = Convert.ToString(row["Nombre"]);
                //cuenta.Domicilio = Convert.ToString(row["IdDomicilioDefault"]);
                Cuenta cue = new Cuenta(cuenta.IdCuenta);
                cuenta.Domicilio = cue.Domicilio;
                cuenta.Telefono = cue.Telefono;

                //cuenta.Telefono = Convert.ToString(row["Telefono"]);
                if (!((CuentasViewCollection)this.Elementos).Contains(cuenta))
                    this.Elementos.Add(cuenta);
            }
        }
        //Fin Cristian 20120110

		public override void ProcesarElementos(ArrayList rows)
		{
			if(this.Elementos == null)
				this.SetElementos(new CuentasViewCollection());
			foreach(System.Data.DataRow row in rows)
			{
				CuentaView cuenta = new CuentaView();
				cuenta.Codigo = Convert.ToString(row["Codigo"]);
				cuenta.IdCuenta = Convert.ToString(row["IdCuenta"]);
				cuenta.Nombre = Convert.ToString(row["Nombre"]);
				//cuenta.Domicilio = Convert.ToString(row["IdDomicilioDefault"]);
				Cuenta cue = new Cuenta(cuenta.IdCuenta);
                cuenta.Domicilio = cue.Domicilio;
				cuenta.Telefono = cue.Telefono;
				//cuenta.Telefono = Convert.ToString(row["Telefono"]);
				if(!((CuentasViewCollection)this.Elementos).Contains(cuenta))
					this.Elementos.Add(cuenta);
			}
		}

		public override void GetJerarquia(string key)
		{
			if(key != null && ! key.Equals(string.Empty))
			{
				tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow row  = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetByPk(key);
				if(row != null)
				{
					Jerarquia = row.Jerarquia;
					IdNomenclatura = row.IdNomenclatura;
				}
			}
		}

		public override void RelacionarJerarquiaElementos()
		{

		}

		public override bool IsValid()
		{

			_errores.Clear();
			bool isvalid = true;
			DataRow row = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetByPk(IdNomenclatura);
			string Descripcion = string.Empty;
			if(row != null)
				Descripcion = Convert.ToString(row["Descripcion"]);
			if(this.Elementos != null)
			{
				foreach(CuentaView cuenta in this.Elementos)
				{
			
					if(!IsValidJerarquia(cuenta))
					{
						ItemDatasetError error = new ItemDatasetError("Cuenta","Cliente Seleccionado","El cliente " +cuenta.Nombre +" ya pertenece a la jerarquía seleccionada");
						_errores.Add( error );
						isvalid = false;
					}
				}
			}
			return isvalid;
		}

		private bool IsValidJerarquia(CuentaView cuenta)
		{

			//if(Jerarquia == null || Jerarquia.Equals(string.Empty)) return false;
			DataSet data = dataaccess.tsa_AgrupCuentas.GetList(cuenta.IdCuenta, Security.IdEmpresa);
			string filtro = String.Format("SUBSTRING(Jerarquia,1,20) = SUBSTRING({0},1,20)", "'" + Jerarquia + "'");			
			DataView dv = new DataView( data.Tables[0], filtro, "", System.Data.DataViewRowState.Unchanged );
			return dv.Count == 0;
				

		}

		public override void Commit()
		{
			_data.tsa_AgrupCuentas.Clear();
			_dataJerarquias.tsa_CuentasJerarquias.Clear();
			if(this.Elementos != null)
			{
				foreach(CuentaView cuenta in this.Elementos)
				{
					tsa_AgrupCuentasDataset.tsa_AgrupCuentasRow row = _data.tsa_AgrupCuentas.Newtsa_AgrupCuentasRow();
					row.IdCuenta = cuenta.IdCuenta; 
					row.Jerarquia = Jerarquia; 
					row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.IdReservado = 0;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					_data.tsa_AgrupCuentas.Addtsa_AgrupCuentasRow(row);

					tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow rowCJ = businessrules.tsa_CuentasJerarquias.GetByPk(cuenta.IdCuenta);
					if (rowCJ==null)
					{
						rowCJ = _dataJerarquias.tsa_CuentasJerarquias.Newtsa_CuentasJerarquiasRow();
						rowCJ["IdCuenta"] = cuenta.IdCuenta;
						CuentasJerarquiaAuxiliar c= new CuentasJerarquiaAuxiliar();
						ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquia,20);
						string nomenclatura = c.nomenclaturaReal(Jerarquia);
						rowCJ[nomenclatura+"a"] = (aux.Count >0 && aux[0] != null)? Convert.ToString(aux[0]) : string.Empty;
						rowCJ[nomenclatura+"b"] = (aux.Count >1 && aux[1] != null)? Convert.ToString(aux[1]) : string.Empty;
						rowCJ[nomenclatura+"c"] = (aux.Count >2 && aux[2] != null)? Convert.ToString(aux[2]) : string.Empty;	
						rowCJ[nomenclatura+"d"] = (aux.Count >3 && aux[3] != null)? Convert.ToString(aux[3]) : string.Empty;
						_dataJerarquias.tsa_CuentasJerarquias.Addtsa_CuentasJerarquiasRow(rowCJ);
					}
					else
					{
						CuentasJerarquiaAuxiliar c= new CuentasJerarquiaAuxiliar();
						ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquia,20);
						string nomenclatura = c.nomenclaturaReal(Jerarquia);
						rowCJ[nomenclatura+"a"] = (aux.Count >0 && aux[0] != null)? Convert.ToString(aux[0]) : string.Empty;
						rowCJ[nomenclatura+"b"] = (aux.Count >1 && aux[1] != null)? Convert.ToString(aux[1]) : string.Empty;
						rowCJ[nomenclatura+"c"] = (aux.Count >2 && aux[2] != null)? Convert.ToString(aux[2]) : string.Empty;	
						rowCJ[nomenclatura+"d"] = (aux.Count >3 && aux[3] != null)? Convert.ToString(aux[3]) : string.Empty;
						_dataJerarquias.tsa_CuentasJerarquias.ImportRow(rowCJ);

					}
				}
			}
		}

		private tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow AddTsa_CuentasJerarquias(string idCuenta)
		{
			tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow row = businessrules.tsa_CuentasJerarquias.GetByPk(idCuenta);
			if (row==null)
				row= businessrules.tsa_CuentasJerarquias.NewRow();
			row["IdCuenta"]=idCuenta;
			return row;
							
		}

		public override void Flush(string IdTransaction)
		{
			mz.erp.dataaccess.tsa_AgrupCuentas.Update(_data.tsa_AgrupCuentas);
			mz.erp.dataaccess.tsa_CuentasJerarquias.Update(_dataJerarquias.tsa_CuentasJerarquias);
		}

		public override TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this._taskName;
			data.Add(_data);
			return data;
		}


		public override mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_agrupCuentas";
			return replication;
		}

		public override void InitializeData()
		{
		}

		public override DataTable SearchAgrupamientos(object target)
		{
			CuentaView cv = (CuentaView) target;
			string IdCuenta = cv.IdCuenta;
			return tsa_AgrupCuentas.GetList(IdCuenta).Tables[0];
		}

		public override void DeleteAgrupamientos(string Hierarchy)
		{
			if(this.Elementos != null)
			{
				foreach(CuentaView cv in this.Elementos)
				{
					string IdCuenta = cv.IdCuenta;
					tsa_AgrupCuentasDataset.tsa_AgrupCuentasRow row = businessrules.tsa_AgrupCuentas.NewRow();
					row = businessrules.tsa_AgrupCuentas.GetByPk(IdCuenta, Hierarchy);
					if (row != null)
					{
						row.Delete();
						businessrules.tsa_AgrupCuentas.Update (row);

						//Si hay otra agrupcuentas no hay q eliminarla solo actualizarla, si no hay otra directamente borro la de cuentas jerarquia
						DataSet dataset = businessrules.tsa_AgrupCuentas.GetList(IdCuenta);
						if (dataset.Tables[0].Rows.Count==0)
						{
							tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow rowCJ = businessrules.tsa_CuentasJerarquias.GetByPk(IdCuenta);
							rowCJ.Delete();
							businessrules.tsa_CuentasJerarquias.Update (rowCJ);
						}
						//Else hay q actualizar la q jerarquia q corresponde = ""
						else 
						{  if (!Jerarquia.Equals(string.Empty)){
							CuentasJerarquiaAuxiliar c = new CuentasJerarquiaAuxiliar();
							string nomenclatura = c.nomenclaturaReal(Jerarquia);
							ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquia,20);
							tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow rowCJ = AddTsa_CuentasJerarquias(IdCuenta);
							rowCJ[nomenclatura+"a"] = string.Empty;
							rowCJ[nomenclatura+"b"] = string.Empty;
							rowCJ[nomenclatura+"c"] = string.Empty;
							rowCJ[nomenclatura+"d"] = string.Empty;
							businessrules.tsa_CuentasJerarquias.Update(rowCJ);
						   }
						}

					}	
				}
			}
		}







	}


	public class CuentaView
	{
		
		public CuentaView()
		{
		}

		private string _codigo = string.Empty;
		private string _idCuenta = string.Empty;
		private string _nombre = string.Empty;
		private string _domicilio = string.Empty;
		private string _tipoDocumento = string.Empty;
		private string _documento = string.Empty;
		private string _telefono = string.Empty;

		public string Telefono
		{
			get
			{
				return _telefono;
			}
			set
			{
				_telefono = value;
			}
		}


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

		public string IdCuenta
		{
			get
			{
				return _idCuenta;
			}
			set
			{
				_idCuenta = value;
			}
		}

		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				_nombre = value;
			}
		}

		public string Domicilio
		{
			get
			{
				return _domicilio;
			}
			set
			{
				_domicilio = value;
			}
		}

		public string TipoDocumento
		{
			get
			{
				return _tipoDocumento;
			}
			set
			{
				_tipoDocumento = value;
			}
		}

		public string Documento
		{
			get
			{
				return _documento;
			}
			set
			{
				_documento = value;
			}
		}

	}

	public class CuentasViewCollection : CollectionBase
	{
		public void Add(CuentaView cuenta)
		{
			this.List.Add(cuenta);
		}

		public CuentaView Get(int index)
		{
			return (CuentaView)this.List[index];
		}

		public bool Contains(CuentaView cuenta)
		{
			foreach(CuentaView cue in this.List)
			{
				if(cue.Codigo.Equals(cuenta.Codigo))
					return true;
			}
			return false;
		}

	}
}
