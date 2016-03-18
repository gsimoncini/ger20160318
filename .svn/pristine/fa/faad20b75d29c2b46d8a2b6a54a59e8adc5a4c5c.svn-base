using System;
using mz.erp.commontypes;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmProductoSucursal.
	/// </summary>
	public class AbmProductoSucursal: ITask, IPersistentTask
	{
		public AbmProductoSucursal()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Variables Privadas
			
		private ProcessManager _processParent;
		private string _taskName;
		private ItemsDatasetErrors _errors = new ItemsDatasetErrors();
		private mz.erp.commontypes.SentenciasReplicacion _sentencia;
		private string _leyendaFormulario = string.Empty;
		private bool _preguntarAlCancelar = false;

		private mz.erp.commontypes.BRTypes.ABMState _state;

		private Productos _productos = new Productos();
		private AbmProductoSucursal.ProductosSucursales _productosSucursales = new ProductosSucursales();
		private AbmProductoSucursal.Sucursales _sucursales = Sucursales.GetInstance();
		private string _textoBotonSiguiente = "Siguiente";
		private string _textoBotonAnterior = "Anterior";

		private tsh_ProductosSucursalesDataset _data = new tsh_ProductosSucursalesDataset();


		#endregion

		#region Variables Publicas
		
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}			
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}


		public ArrayList ProductosInstance
		{
			get{return _productos.ToArrayList();}
		}

		public AbmProductoSucursal.ProductosSucursales ProductosSucursalesInstance
		{
			get{return _productosSucursales;}
		}

		public AbmProductoSucursal.Sucursales SucursalesInstance
		{
			get{return _sucursales;}
		}

		public string LeyendaFormulario
		{
			get{return _leyendaFormulario;}
		}

		public bool PreguntarAlCancelar
		{
			get {
				return _preguntarAlCancelar ;
			}
		}
		

		#endregion

		#region Metodos Privados
			
		private void LoadFromAbmProductos(AbmProductos prod)
		{
			ProductoView p = new ProductoView();
			p.IdProducto = prod.IdProducto;
			p.Codigo = prod.Codigo;
			p.Descripcion = prod.Descripcion;
			_productos.Add(p);
			DataSet data = mz.erp.businessrules.tsh_ProductosSucursales.GetList(p.IdProducto, long.MinValue);
			foreach(DataRow row in data.Tables[0].Rows)
			{
				long IdSucursal = Convert.ToInt64(row["IdSucursal"]);
				bool Activo = Convert.ToBoolean(row["Activo"]);
				SucursalView suc = _sucursales.Find(IdSucursal);
				if(suc != null && Activo)
				{
					ProductoSucursal ps = new ProductoSucursal();
					ps.IdSucursal = IdSucursal;
					ps.IdProducto = p.IdProducto;
					ps.Producto = p.Descripcion;
					ps.Sucursal = suc.Sucursal;
					ps.IdEmpresa = Security.IdEmpresa;
					ps.Activo = true;
					_productosSucursales.Add(ps);
				}

			}
		}
		
		#endregion

		#region Metodos Publicos

		public void RemoveProductoSucursal(string IdProd, long IdSuc)
		{
			
			
		}

		public void AddProductoSucursal(string IdProd, long IdSuc)
		{
			ProductoView prod = _productos.Find(IdProd);
			SucursalView suc = _sucursales.Find(IdSuc);
			if(_productosSucursales.Find(prod.IdProducto, suc.IdSucursal) == null)
			{
				ProductoSucursal ps = new ProductoSucursal();
				ps.IdSucursal = suc.IdSucursal;
				ps.IdProducto = prod.IdProducto;
				ps.Producto = prod.Descripcion;
				ps.Sucursal = suc.Sucursal;
				ps.IdEmpresa = Security.IdEmpresa;
				ps.Activo = true;
				_productosSucursales.Add(ps);
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
		}

		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.AbmProductos)))
			{
				
				AbmProductos prod = (AbmProductos) sender;
				LoadFromAbmProductos(prod);
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
			
		}


		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{
			InitializeData();
			NewData();
		}

		public bool IsValidForStartProcess()
		{
			_errors.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errors.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			
			return true;
		}

		public bool AllowShow()
		{
			
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			
			return _errors;
		}

		public string GetWarnings()
		{
			
			return null;
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
		}

		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if (OnTaskBeforeExecute != null)
			{
				this.OnTaskBeforeExecute(this,new System.EventArgs() );
			}
			IsValid();
			if (OnTaskAfterExecute != null)
			{
				this.OnTaskAfterExecute(this,new System.EventArgs() );
			}
		}

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.Add(_dataProductosSucursales);
			return data;
		}

		public void Commit()
		{
			_dataProductosSucursales = new tsh_ProductosSucursalesDataset();
			foreach(ProductoView prod in this._productos)
			{
				_dataProductosSucursales.Merge(mz.erp.businessrules.tsh_ProductosSucursales.GetList(prod.IdProducto, long.MinValue ));
			}
			/*Deshabilito los eliminados*/
			foreach(DataRow row in _dataProductosSucursales.tsh_ProductosSucursales.Rows)
			{
				long IdSucursal = Convert.ToInt64(row["IdSucursal"]);
				bool Activo = Convert.ToBoolean(row["Activo"]);
				string IdProducto = Convert.ToString(row["IdProducto"]);
				ProductoSucursal ps = this._productosSucursales.Find(IdProducto, IdSucursal);
				if(ps == null) row["Activo"] = false;

			}
			/*Habilito*/
			foreach(ProductoSucursal prodSuc in this._productosSucursales)
			{
				DataRow row = _dataProductosSucursales.tsh_ProductosSucursales.FindByIdProductoIdSucursalIdEmpresa(prodSuc.IdProducto, prodSuc.IdSucursal,prodSuc.IdEmpresa);
				if( row != null)
				{
					row["Activo"] = true;
				}
				else
				{
					tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowPS = mz.erp.businessrules.tsh_ProductosSucursales.NewRow();
					rowPS.IdProducto = prodSuc.IdProducto;
					rowPS.IdSucursal = prodSuc.IdSucursal;
					rowPS.Activo = true;
					_dataProductosSucursales.tsh_ProductosSucursales.LoadDataRow(rowPS.ItemArray,false);

				}
			}

		}

		public void Flush(string IdTransaction)
		{
			mz.erp.dataaccess.tsh_ProductosSucursales.Update(_dataProductosSucursales, IdTransaction, this.GetSentenceReplication());	
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			foreach( TaskCollectionData taskData in _processCollectionData)
			{
				if (taskData.TaskName.CompareTo("ABMProductos") == 0 )
				{
					foreach ( DataSet data in taskData )
					{
						foreach ( System.Data.DataTable table in data.Tables )
						{
							if (table.TableName.CompareTo("tsh_Productos")==0)
							{
								if (table.Rows.Count>0)
								{
									string IdProducto = Convert.ToString(table.Rows[0]["IdProducto"]);
									foreach(DataRow row in _dataProductosSucursales.tsh_ProductosSucursales.Rows)
									{
										row["IdProducto"] = IdProducto;
									}
								}
							}
						}
					}
				}
			}
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_ProductosSucursales";
			return replication;
		}

		public bool GetHasSaved()
		{
			return false;
		}

		#endregion

		#region Custom Members
		private mz.erp.commontypes.data.tsh_ProductosSucursalesDataset _dataProductosSucursales;

		private void GetDataProductosSucursales()
		{
						
		}
		private void NewData()
		{
			//_rowProductoSucursal = mz.erp.businessrules.tsh_ProductosSucursales.NewRow();
			GetDataProductosSucursales();	
			_state = BRTypes.ABMState.Alta;
		}
		private void EditData( string IdProducto, long IdSucursal )
		{
			_dataProductosSucursales = mz.erp.businessrules.tsh_ProductosSucursales.GetList(IdProducto, IdSucursal);
			GetDataProductosSucursales();	
			_state = BRTypes.ABMState.Modificacion;
		}
		
		private void ViewData( string IdProducto, long IdSucursal )
		{
			GetDataProductosSucursales();	
			_state = BRTypes.ABMState.Consulta;
		}
		private void InitializeData()
		{
			
			SetLeyendaFormulario();
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
		}

		

		private void SetLeyendaFormulario()
		{	
			switch (_state)
			{	  
				case mz.erp.commontypes.BRTypes.ABMState.Alta :
					_leyendaFormulario = "Alta Producto";
					break;
				case mz.erp.commontypes.BRTypes.ABMState.Modificacion :
					_leyendaFormulario = "Modificacion de Producto";
					break;

			}
		}
		#endregion

		#region Clases Auxiliares

		public sealed  class ProductosSucursales: CollectionBase
		{
			public void Add(ProductoSucursal item)
			{
				this.List.Add(item);
			}

			public void Remove(string IdProducto, long IdSucursal)
			{
				ProductoSucursal ps = this.Find(IdProducto, IdSucursal);
				if(ps != null)
				{
					this.List.Remove(ps);
				}
			}

			public ProductoSucursal Find(string IdProducto, long IdSucursal)
			{
				foreach(ProductoSucursal ps in this.List)
				{
					if(ps.IdProducto.Equals(IdProducto) && ps.IdSucursal.Equals(IdSucursal))
						return ps;
					

				}
				return null;
			}
		}

		public sealed class ProductoSucursal
		{
			#region Constructor
				
			public ProductoSucursal()
			{
				
			}
				
			#endregion
			
			#region Variables Privadas
					
				private string _idProducto = string.Empty;
				private long _idSucursal = 0;
				private long _idEmpresa = 0;
				private bool _activo = false;
				private string _sucursal = string.Empty;
				private string _producto = string.Empty;

				
			#endregion


			#region Variables Publicas
			
			public string IdProducto
			{
				get{return _idProducto;}
				set{ _idProducto = value;}
			}
			public long IdSucursal
			{
				get{return _idSucursal;}
				set{_idSucursal = value;}
			}

			public long IdEmpresa
			{
				get{return _idEmpresa;}
				set {_idEmpresa = value;}
			}

			public bool Activo 
			{
				get{return _activo;}
				set {_activo = value;}
			}

			public string Sucursal
			{
				get{return _sucursal;}
				set{_sucursal = value;}
			}

			public string Producto
			{
				get{return _producto;}
				set{_producto = value;}
			}


			#endregion
		}

		public  sealed class Sucursales:CollectionBase
		{
			private static Sucursales _instance = null;

			private Sucursales(){}
			
			public static Sucursales GetInstance()
			{
				if(_instance == null)
				{
					_instance = new Sucursales();
					_instance.GetSucursales();
				}
				return _instance;
			}
			private void GetSucursales()
			{
				DataSet data = mz.erp.businessrules.sy_Sucursales.GetList();
				foreach(DataRow row in data.Tables[0].Rows)
				{
					SucursalView suc = new SucursalView();
					suc.IdSucursal = Convert.ToInt64(row["IdSucursal"]);
					suc.Sucursal = Convert.ToString(row["Descripcion"]);
					suc.Direccion = Convert.ToString(row["Direccion"]);
					suc.IdLocalidad = Convert.ToString(row["IdLocalidad"]);
					this.Add(suc);
				}
			}

			public SucursalView Find(long IdSucursal)
			{
				foreach(SucursalView suc in this.List)
				{
					if(suc.IdSucursal.Equals(IdSucursal))
						return suc;
				}
				return null;
			}
			
			public void Add(SucursalView sucursal)
			{
				this.List.Add(sucursal);
			}
		}

		public  sealed class SucursalView
		{
			public SucursalView(){}
			public SucursalView(long IdSucursal, string Nombre, string Direccion, string IdLocalidad)
			{
				_idSucursal = IdSucursal;
				_sucursal = Nombre;
				_direccion = Direccion;
				_idLocalidad = IdLocalidad;
			}

			
			private long _idSucursal;
			private string _sucursal = string.Empty;
			private string _direccion = string.Empty;
			private string _idLocalidad = string.Empty;


			public long IdSucursal
			{
				get{return _idSucursal;}
				set{_idSucursal = value;}
			}

			public string Sucursal
			{
				get{return _sucursal;}
				set{_sucursal = value;}
			}

			public string Direccion
			{
				get{return _direccion;}
				set{_direccion = value;}
			}

			public string IdLocalidad
			{
				get{return _idLocalidad;}
				set{_idLocalidad = value;}
			}
		}

		public  sealed class ProductoView
		{
			public ProductoView(string IdProducto)
			{
				tsh_ProductosDataset.tsh_ProductosRow row = mz.erp.businessrules.tsh_Productos.GetByPk(IdProducto);
				if(row != null)
				{
					_idProducto = IdProducto;
					_codigo = row.Codigo;
					_descripcion = row.Descripcion;
				}
			}

			public ProductoView(){}

			private string _idProducto = string.Empty;
			private string _codigo = string.Empty;
			private string _descripcion = string.Empty;

			public string IdProducto
			{
				get{return _idProducto;}
				set{_idProducto = value;}
			}

			public string Codigo
			{
				get{return _codigo;}
				set{_codigo = value;}
			}

			public string Descripcion
			{
				get{return _descripcion;}
				set{_descripcion = value;}
			}


		}

		public sealed class Productos:CollectionBase
		{
			public void Add(ProductoView prod)
			{
				this.List.Add(prod);
			}

			public ProductoView Find(string IdProducto)
			{
				foreach(ProductoView prod in this.List)
				{
					if(prod.IdProducto.Equals(IdProducto))
						return prod;
				}
				return null;
			}

			public ArrayList ToArrayList()
			{
				return new ArrayList(this.List);
			}
		}
		#endregion
		
	}
}
