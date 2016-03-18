using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmProductosAgrupamientos.
	/// </summary>
	public class AbmProductosAgrupamientos : Agrupamientos	
	{
		
		#region Constructores

		public AbmProductosAgrupamientos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#endregion
		
		#region Variables privadas

		private tsa_AgrupCuentasDataset _data = new tsa_AgrupCuentasDataset();

		#endregion

		#region Eventos

			public event System.EventHandler ObjectHasChanged;

		#endregion

		#region Metodos Publicos

		public  override string  GetUIClass()
		{
			return "mz.erp.ui.controllers.tsh_productos";
		}

		public override ArrayList GetFields()
		{
			return new ArrayList();
		}

		public override string GetUIClassAgrupamientos()
		{
			return "mz.erp.ui.controllers.tsh_AgrupProductos";
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
				
				//table = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetNomenclaturas().tsh_JerarquiaAgrupProd;
				table = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetNomenclaturas();
				header = new Node(key, "Agrupamientos");
			}
			else
			{
				table = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetList(key, false).tsh_JerarquiaAgrupProd;
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


		public override void ProcesarElementos(ArrayList rows)
		{
			if(this.Elementos == null)
				this.SetElementos(new ProductosViewCollection());
			foreach(System.Data.DataRow row in rows)
			{
				ProductoView producto = new ProductoView();
				producto.Codigo = Convert.ToString(row["Codigo"]);
				producto.IdProducto = Convert.ToString(row["IdProducto"]);
				producto.Descripcion = Convert.ToString(row["Descripcion"]);
				if(!this.Elementos.Contains(producto))
					this.Elementos.Add(producto);
			}
		}

		public override void GetJerarquia(string key)
		{
			Jerarquia = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(key).Jerarquia;
		}

		public override void RelacionarJerarquiaElementos()
		{

		}

		public override bool IsValid()
		{

			_errores.Clear();
			bool isvalid = true;
			foreach(ProductoView prod in this.Elementos)
			{
			
				if(!IsValidJerarquia(prod))
				{
					ItemDatasetError error = new ItemDatasetError("Producto","Producto Seleccionado","El producto " + prod.Descripcion +" ya pertenece a la jerarquia");
					_errores.Add( error );
					isvalid = false;
				}
			}
			return isvalid;
		}

		private bool IsValidJerarquia(ProductoView prod)
		{

			tsh_AgrupProductosExDataset data = dataaccess.tsh_AgrupProductos.GetList(prod.IdProducto, Security.IdEmpresa);
			string filtro = String.Format("SUBSTRING(Jerarquia,1,20) = SUBSTRING({0},1,20)", "'" + Jerarquia + "'");			
			DataView dv = new DataView( data.tsh_AgrupProductos, filtro, "", System.Data.DataViewRowState.Unchanged );
			return dv.Count == 0;
				

		}


		public override void Commit()
		{
		}


		public override void Flush(string IdTransaction)
		{
			
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
			replication.NombreTabla = "dataaccess.tsh_agrupProductos";
			return replication;
		}

		public override void InitializeData()
		{
		}

		public override DataTable SearchAgrupamientos(object target)
		{
			ProductoView cv = (ProductoView) target;
			string IdProducto = cv.IdProducto;
			return tsh_AgrupProductos.GetList(IdProducto).Tables[0];
		}

		public override void DeleteAgrupamientos(string Hierarchy)
		{
		}







		#endregion

	}

	public sealed  class ProductoView
	{
		
		public ProductoView()
		{
		}

		private string _codigo = string.Empty;
		private string _idProducto = string.Empty;
		private string _descripcion = string.Empty;
		
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				_descripcion = value;
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

		public string IdProducto
		{
			get
			{
				return _idProducto;
			}
			set
			{
				_idProducto = value;
			}
		}

		
	}

	public sealed class ProductosViewCollection : CollectionBase
	{
		public void Add(ProductoView producto)
		{
			this.List.Add(producto);
		}

		public ProductoView Get(int index)
		{
			return (ProductoView)this.List[index];
		}

		public bool Contains(ProductoView producto)
		{
			foreach(ProductoView cue in this.List)
			{
				if(cue.Codigo.Equals(producto.Codigo))
					return true;
			}
			return false;
		}

	}
}
