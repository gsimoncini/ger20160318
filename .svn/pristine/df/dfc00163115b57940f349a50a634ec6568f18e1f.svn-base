using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AgrupamientosProveedores.
	/// </summary>
	public class AgrupamientosProveedores : Agrupamientos
	{
		#region Constructores

		public AgrupamientosProveedores()
		{
		}

		#endregion

		#region Variables privadas
		private tpu_AgrupProveedoresDataset _data = new tpu_AgrupProveedoresDataset();
		private tpu_ProveedoresJerarquiasDataset _dataJerarquias = new tpu_ProveedoresJerarquiasDataset();

		#endregion

		#region Miembros de ITask
		public event System.EventHandler ObjectHasChanged;
		#endregion

		#region Miembros de IPersistentTask
		#endregion

		#region Miembros de Agrupamientos
		public  override string  GetUIClass()
		{
			return "mz.erp.ui.controllers.tpu_Proveedores";
		}

		public override ArrayList GetFields()
		{
			return new ArrayList();
		}

		public override string GetUIClassAgrupamientos()
		{
			return "mz.erp.ui.controllers.tpu_AgrupProveedores";
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
				table = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetNomenclaturas();
				header = new Node(key, "Agrupamientos");
			}
			else
			{
				table = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetList(key);
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
        public override void Agregar(String codigoProveedor) {
            if (this.Elementos == null)
                this.SetElementos(new ProveedoresViewCollection());
            tpu_ProveedoresDataset.tpu_ProveedoresRow row = mz.erp.businessrules.tpu_Proveedores.GetByCodigo(codigoProveedor);
            if (row != null)
            {
                ProveedorView proveedor = new ProveedorView();
                proveedor.Codigo = Convert.ToString(row["Codigo"]);
                proveedor.IdProveedor = Convert.ToString(row["IdProveedor"]);
                proveedor.Nombre = Convert.ToString(row["Nombre"]);
                proveedor.Domicilio = Convert.ToString(row["Domicilio"]);
                proveedor.Telefonos = Convert.ToString(row["Telefonos"]);
           
                if (!((ProveedoresViewCollection)this.Elementos).Contains(proveedor))
                    this.Elementos.Add(proveedor);
            }
        }
        //Fin Cristian 20120110

		public override void ProcesarElementos(ArrayList rows)
		{
			if(this.Elementos == null)
				this.SetElementos(new ProveedoresViewCollection());
			foreach(System.Data.DataRow row in rows)
			{
				ProveedorView proveedor = new ProveedorView();
				proveedor.Codigo = Convert.ToString(row["Codigo"]);
				proveedor.IdProveedor = Convert.ToString(row["IdProveedor"]);
				proveedor.Nombre = Convert.ToString(row["Nombre"]);
				proveedor.Domicilio = Convert.ToString(row["Domicilio"]);
				proveedor.Telefonos = Convert.ToString(row["Telefonos"]);
				if(!((ProveedoresViewCollection)this.Elementos).Contains(proveedor))
					this.Elementos.Add(proveedor);
			}
		}

		public override void GetJerarquia(string key)
		{
			if(key != null && ! key.Equals(string.Empty))
			{
				tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresRow row  = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetByPk(key);
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
			DataRow row = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetByPk(IdNomenclatura);
			string Descripcion = string.Empty;
			if(row != null)
				Descripcion = Convert.ToString(row["Descripcion"]);
			if(this.Elementos != null)
			{
				foreach(ProveedorView prov in this.Elementos)
				{
			
					if(!IsValidJerarquia(prov))
					{
						ItemDatasetError error = new ItemDatasetError("Proveedor","Proveedor Seleccionado","El proveedor " +prov.Nombre +" ya pertenece a la jerarquía seleccionada");
						_errores.Add( error );
						isvalid = false;
					}
				}
			}
			return isvalid;
		}

		private bool IsValidJerarquia(ProveedorView proveedor)
		{

			DataSet data = dataaccess.tpu_AgrupProveedores.GetList(proveedor.IdProveedor, Security.IdEmpresa);
			string filtro = String.Format("SUBSTRING(Jerarquia,1,20) = SUBSTRING({0},1,20)", "'" + Jerarquia + "'");			
			DataView dv = new DataView( data.Tables[0], filtro, "", System.Data.DataViewRowState.Unchanged );
			return dv.Count == 0;				

		}

		public override void Commit()
		{
			_data.tpu_AgrupProveedores.Clear();
			_dataJerarquias.tpu_ProveedoresJerarquias.Clear();
			if(this.Elementos != null)
			{
				foreach(ProveedorView prov in this.Elementos)
				{
					tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow row = _data.tpu_AgrupProveedores.Newtpu_AgrupProveedoresRow();
					row.IdProveedor = prov.IdProveedor; 
					row.Jerarquia = Jerarquia; 
					row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.IdReservado = 0;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					_data.tpu_AgrupProveedores.Addtpu_AgrupProveedoresRow(row);

					tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow rowPJ = businessrules.tpu_ProveedoresJerarquias.GetByPk(prov.IdProveedor);
					if (rowPJ==null)
					{
						rowPJ = _dataJerarquias.tpu_ProveedoresJerarquias.Newtpu_ProveedoresJerarquiasRow();
						rowPJ["IdProveedor"] = prov.IdProveedor;
						ProveedoresJerarquiaAuxiliar p = new ProveedoresJerarquiaAuxiliar();
						ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquia,20);
						string nomenclatura = p.nomenclaturaReal(Jerarquia);
						rowPJ[nomenclatura+"a"] = (aux.Count >0 && aux[0] != null)? Convert.ToString(aux[0]) : string.Empty;
						rowPJ[nomenclatura+"b"] = (aux.Count >1 && aux[1] != null)? Convert.ToString(aux[1]) : string.Empty;
						rowPJ[nomenclatura+"c"] = (aux.Count >2 && aux[2] != null)? Convert.ToString(aux[2]) : string.Empty;	
						rowPJ[nomenclatura+"d"] = (aux.Count >3 && aux[3] != null)? Convert.ToString(aux[3]) : string.Empty;
						_dataJerarquias.tpu_ProveedoresJerarquias.Addtpu_ProveedoresJerarquiasRow(rowPJ);
					}
					else
					{
						ProveedoresJerarquiaAuxiliar p = new ProveedoresJerarquiaAuxiliar();
						ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquia,20);
						string nomenclatura = p.nomenclaturaReal(Jerarquia);
						rowPJ[nomenclatura+"a"] = (aux.Count >0 && aux[0] != null)? Convert.ToString(aux[0]) : string.Empty;
						rowPJ[nomenclatura+"b"] = (aux.Count >1 && aux[1] != null)? Convert.ToString(aux[1]) : string.Empty;
						rowPJ[nomenclatura+"c"] = (aux.Count >2 && aux[2] != null)? Convert.ToString(aux[2]) : string.Empty;	
						rowPJ[nomenclatura+"d"] = (aux.Count >3 && aux[3] != null)? Convert.ToString(aux[3]) : string.Empty;
						_dataJerarquias.tpu_ProveedoresJerarquias.ImportRow(rowPJ);

					}




				}
			}
		}

		private tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow AddTpu_ProveedoresJerarquias(string idProveedor)
		{
			tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow row = businessrules.tpu_ProveedoresJerarquias.GetByPk(idProveedor);
			if (row==null)
				row= businessrules.tpu_ProveedoresJerarquias.NewRow();
			row["IdProveedor"]=idProveedor;
			return row;
							
		}

		public override void Flush(string IdTransaction)
		{
			mz.erp.dataaccess.tpu_AgrupProveedores.Update(_data.tpu_AgrupProveedores);
			mz.erp.dataaccess.tpu_ProveedoresJerarquias.Update(_dataJerarquias.tpu_ProveedoresJerarquias);
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
			replication.NombreTabla = "dataaccess.tpu_AgrupProveedores";
			return replication;
		}

		public override void InitializeData()
		{
		}

		public override DataTable SearchAgrupamientos(object target)
		{
			ProveedorView pv = (ProveedorView) target;
			string IdProveedor = pv.IdProveedor;
			return tpu_AgrupProveedores.GetList(IdProveedor).Tables[0];
		}

		public override void DeleteAgrupamientos(string Hierarchy)
		{
			if(this.Elementos != null)
			{
				foreach(ProveedorView pv in this.Elementos)
				{
					string IdProveedor = pv.IdProveedor;
					tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow row = businessrules.tpu_AgrupProveedores.NewRow();
					row = businessrules.tpu_AgrupProveedores.GetByPk(IdProveedor, Hierarchy);
					if (row != null)
					{
						row.Delete();
						businessrules.tpu_AgrupProveedores.Update (row);

						//Si hay otra agrupproveedores no hay q eliminarla solo actualizarla, si no hay otra directamente borro la de proveedor jerarquia
						DataSet dataset = businessrules.tpu_AgrupProveedores.GetList(IdProveedor);
						if (dataset.Tables[0].Rows.Count==0)
						{
							tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow rowPJ = businessrules.tpu_ProveedoresJerarquias.GetByPk(IdProveedor);
							rowPJ.Delete();
							businessrules.tpu_ProveedoresJerarquias.Update(rowPJ);
						}
						//Else hay q actualizar la q jerarquia q corresponde = ""
						else 
						{
							ProveedoresJerarquiaAuxiliar p = new ProveedoresJerarquiaAuxiliar();
							string nomenclatura = p.nomenclaturaReal(Jerarquia);
							ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquia,20);
							tpu_ProveedoresJerarquiasDataset.tpu_ProveedoresJerarquiasRow rowPJ = AddTpu_ProveedoresJerarquias(IdProveedor);
							rowPJ[nomenclatura+"a"] = string.Empty;
							rowPJ[nomenclatura+"b"] = string.Empty;
							rowPJ[nomenclatura+"c"] = string.Empty;
							rowPJ[nomenclatura+"d"] = string.Empty;
							businessrules.tpu_ProveedoresJerarquias.Update(rowPJ);
						}


					}	
				}
			}
		}
		#endregion
	
		#region Eventos y delegados
		#endregion
	
		#region Métodos públicos
		#endregion
	
		#region Propiedades
		#endregion
	
		#region Métodos Privados
		#endregion
	}

	public class ProveedorView
	{
		
		public ProveedorView()
		{
		}

		private string _codigo = string.Empty;
		private string _idProveedor = string.Empty;
		private string _nombre = string.Empty;
		private string _domicilio = string.Empty;
		private string _tipoDocumento = string.Empty;
		private string _documento = string.Empty;
		private string _telefonos = string.Empty;

		public string Telefonos
		{
			get
			{
				return _telefonos;
			}
			set
			{
				_telefonos = value;
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

		public string IdProveedor
		{
			get
			{
				return _idProveedor;
			}
			set
			{
				_idProveedor = value;
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

	public class ProveedoresViewCollection : CollectionBase
	{
		public void Add(ProveedorView proveedor)
		{
			this.List.Add(proveedor);
		}

		public ProveedorView Get(int index)
		{
			return (ProveedorView)this.List[index];
		}

		public bool Contains(ProveedorView proveedor)
		{
			foreach(ProveedorView prov in this.List)
			{
				if(prov.Codigo.Equals(proveedor.Codigo))
					return true;
			}
			return false;
		}

	}

}
