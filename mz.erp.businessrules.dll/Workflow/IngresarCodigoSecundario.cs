using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de IngresarCodigoSecundario.
	/// </summary>
	public class IngresarCodigoSecundario: ITask, IPersistentTask
	{
		public IngresarCodigoSecundario()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Variables Privadas
		private DataSet _dataProductos = new tsh_ProductosDataset();
		private ArrayList _productos = new ArrayList();
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
		#endregion
		
		#region Propiedades

		private string _textoBotonAnterior = "Anterior";
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
		private string _textoBotonSiguiente = "Siguiente";
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

		private string _leyendaFormulario = "Ingreso de códigos secundarios";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _leyendaFormulario;
				}
				else 
				{
					return valor;
				}
			}
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
		public ArrayList Productos
		{
			get{return _productos;}
			set{_productos = value;}
		}



		#endregion

		#region Eventos
		public event System.EventHandler ProductosCollectionChanged;
		#endregion

		#region Miembros de ITask

		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

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
			if(this._processParent.Process.ProcessName.Equals("ProcesoOrdenDeCompraIngresarMercaderia"))
			{
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra)))
				{
					comprobantes.ComprobanteDeCompra task = (comprobantes.ComprobanteDeCompra)sender;
					LoadFromComprobanteDeCompra(task);
					if (ProductosCollectionChanged != null)
					{
						ProductosCollectionChanged( this, new System.EventArgs() );
					}

				}
			}

		}

		private void LoadFromComprobanteDeCompra(comprobantes.ComprobanteDeCompra comprobanteDeCompra)
		{
			_productos.Clear();
			foreach(ItemComprobanteCompra item in comprobanteDeCompra.Items.List)
			{
				if(item.ObligaCodigoBarra && (item.CodigoSecundario == null || item.CodigoSecundario.Equals(string.Empty)))
				{
					ProductoCS producto = new ProductoCS();
					producto.IdProducto = item.IdProducto;
					producto.Codigo = item.Codigo;
					producto.CodigoSecundario = item.CodigoSecundario;
					producto.Descripcion = item.Descripcion;								
					_productos.Add(producto);
				}
			}
		}
	

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{
		}
		
		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}
		
		public bool IsValid()
		{			
			_errores.Clear();
			bool isvalid = true;
			return isvalid;			
		}

		public bool AllowShow()
		{
			if(this._processParent.Process.ProcessName.Equals("ProcesoOrdenDeCompraIngresarMercaderia") && _productos.Count == 0)
				return false;
			else
                return true;
		}
		public void FormHasClosed() 
		{
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _errores;
		}

		public string GetWarnings()
		{			
			return string.Empty;
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
			return this._taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
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
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._dataProductos);
			//data.Add( (DataSet) this._dataProductosSucursales);
			return data;			
		}

		public void Commit()
		{
			/*Ver para q procesos el commit se hace de esta manera.
			 * Tener en cuenta q s el producto se esta creando y esta tarea participa con otra tarea de la
			 * creacion de dicho producto, no se va hacer un update sino un insert
			 * 
			 * */

			foreach(ProductoCS prod in this._productos)
			{
				if (prod.CodigoSecundario != String.Empty)
				{
					DataRow row = mz.erp.businessrules.tsh_Productos.GetByPk(prod.IdProducto);
					_dataProductos.Tables[0].ImportRow(row);
					DataRow rowProd = ((tsh_ProductosDataset) _dataProductos).tsh_Productos.FindByIdProducto(prod.IdProducto);				
					rowProd["CodigoSecundario"] = prod.CodigoSecundario;				
				}				
			}
		}

		private static SentenciasReplicacion  GenerateReplicaction()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_Productos";
			return replication;
			
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			SentenciasReplicacion _replicacion = GenerateReplicaction();
			mz.erp.dataaccess.tsh_Productos.Update(this._dataProductos, IdTransaction, _replicacion);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());	
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			
			return GenerateReplicaction();
		}

		public bool GetHasSaved()
		{
			
			return false;
		}

		#endregion

		#region Métodos públicos
		public void NodoActual()
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
			
			j1 = jers[0];
			j2 = jers[1];
			j3 = jers[2];
			j4 = jers[3];
			j5 = jers[4];
			j6 = jers[5];
			j7 = jers[6];
			j8 = jers[7];
			DataTable table = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquiaSinCodigo(j1,j2,j3,j4,j5,j6,j7,j8, Security.IdSucursal, Security.IdEmpresa);
			_productos.Clear();
			foreach (DataRow row in table.Rows)
			{
				ProductoCS producto = new ProductoCS();
				producto.IdProducto =  Convert.ToString(row["IdProducto"]);
				producto.Codigo = Convert.ToString(row["Codigo"]);
				producto.CodigoSecundario = Convert.ToString(row["CodigoSecundario"]);
				producto.Descripcion = Convert.ToString(row["Descripcion"]);								
				_productos.Add(producto);
			}
			
			if (ProductosCollectionChanged != null)
			{
				ProductosCollectionChanged( this, new System.EventArgs() );
			}

		}
		private string BuildJerarquia(ArrayList je)
		{
			/*if(je.Count > 0)
			{
				ItemJerarquia it = (ItemJerarquia) je[0];
				return it.NodeKeyPath;
			}
			return string.Empty;			*/			
			ArrayList narray = new ArrayList();
			foreach (object item in je) 
			{
				ItemJerarquia it = (ItemJerarquia) item;
				narray.Add(it.NodeKey);
			}
			return Util.PackString(narray);
		}

		#endregion
	}
	public class ProductoCS 
	{
		public ProductoCS( )
		{
		}
		private string _idProducto = "";
		public string IdProducto 
		{
			get {return _idProducto;}
			set { _idProducto = value;}
		}
		private string _codigo = "";
		public string Codigo
		{
			get {return _codigo;}
			set { _codigo = value;}
		}
		private string _codigoSecundario = "";
		public string CodigoSecundario 
		{
			get {return _codigoSecundario;}
			set { _codigoSecundario = value;}
		}
		
		private string _descripcion = "";
		public string Descripcion 
		{
			get {return _descripcion;}
			set { _descripcion = value;}
		}
	}
}
