using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Reflection;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ABMComprobantesCategoriaIva.
	/// </summary>
	public class ABMComprobantesCategoriaIva:ITask, IPersistentTask
	{
		public ABMComprobantesCategoriaIva()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Variables Privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		private ArrayList _tiposComprobantes;
		private ArrayList _todasCategoriasIva;
		private TipoComprobanteCategoriaIva _tipoComprobanteCategoriaIva=new TipoComprobanteCategoriaIva();
        private tsy_CategoriasIvaDataset. tsy_CategoriasIvaDataTable _categoriasIva;
		//Variable de mi clase
		private string _idCategoriaIva="CF";
		//Variables de bd q necesita la vista para configurarse, por ejemplo
		private string _textoBotonAnterior = "Anterior";
		private string _textoBotonSiguiente = "Guardar";
		private string _leyenda="Abm Comprobantes Categoria Iva";		
		private bool _preguntarAlCancelar = false;
		private mz.erp.commontypes.data.tsy_TiposDeComprobantesCategoriaIvaDataset _data = new mz.erp.commontypes.data.tsy_TiposDeComprobantesCategoriaIvaDataset();

		public mz.erp.commontypes.data.tsy_TiposDeComprobantesCategoriaIvaDataset data
		{
			get
			{
				return _data;
			}
			set
			{
				_data = value;
			}
		}
  		#endregion
		#region propiedades
		public string TextoBotonAnterior
		{
			get 
			{
				return _textoBotonAnterior;
				
			}
			set
			{
				_textoBotonAnterior=value;
			}
		}
				
		public string TextoBotonSiguiente
		{
			get 
			{		
				return _textoBotonSiguiente;
				
			}
			set
			{
				_textoBotonSiguiente=value;
			}
		}
		public string Leyenda
		{
			get 
			{
					return _leyenda;
				
			}
			set 
			{
				_leyenda=value;
				
			}
		}
		public bool PreguntarAlCancelar
		{
			get 
			{
				return _preguntarAlCancelar ;
				
			}
			set 
			{
				_preguntarAlCancelar =value;
				
			}
		}
		public string IdCategoriaIva
		{
			get{return _idCategoriaIva;}
			set
			{
				if(_idCategoriaIva != value)
					{
						_idCategoriaIva = value;
						if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());					
					}
			}
			
		}
		public ArrayList TiposComprobantes 
		{
			get
			{
				return _tiposComprobantes;		
			}
		}
		public ArrayList TodasCategoriasIva 
		{
			get
			{
				return _todasCategoriasIva;		
			}
		}
		public System.Data.DataTable CategoriasIva 
		{
			get {return _categoriasIva;}
		} 
		private ArrayList _modificaciones=new ArrayList();
		public ArrayList Modificaciones 
		{
			get
			{
				return _modificaciones;		
			}
		}
		

		#endregion
		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		

		public virtual void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public virtual bool AllowPrevious()
		{
			return true;
		}
		public  void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public  void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public  void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		public  void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}
		//Siempre mismo codigo
		public  bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}
		public virtual bool IsValid()
		{
			//ValidarDatos();
			if (_errores.Count > 0)
				return false;
			else
				return true;
		}



		// Levanta la inicializacion de la tarea
		public  void Init()
		{ 
			_tiposComprobantes=erp.businessrules.tsy_TiposDeComprobantes.GetTiposDeComprobantesTodos();
			
			_categoriasIva=tsy_CategoriasIva.GetList().tsy_CategoriasIva;
			_todasCategoriasIva=new ArrayList();
			foreach (System.Data.DataRow _row in _categoriasIva)
			{	
				string _categoria=Convert.ToString(_row["IdCategoriaIva"]);
				_todasCategoriasIva.Add(_categoria);
				ArrayList _todos=new ArrayList();
				foreach (TiposDeComprobantesView tcv in _tiposComprobantes)
				{
					EstadoObjeto comp=new EstadoObjeto(tcv);
					_todos.Add(comp);
				}
				ArrayList _tipoCompCategoria= erp.businessrules.tsy_TiposDeComprobantesCategoriaIva.GetTiposDeComprobantesCategoria(_categoria);
				_tipoComprobanteCategoriaIva.asignarTodosTiposComprobantesCategoria(_categoria,_todos);
				_tipoComprobanteCategoriaIva.asignarTiposComprobantesCategoria(_categoria,_tipoCompCategoria);

			}
			//Lo de la grilla de abajo
			this.Modificar();
						
			//Leyenda del formulario
			string variable;
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Leyenda";
			Leyenda = Variables.GetValueString(variable);
			//Texto Boton Siguiente
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
			TextoBotonAnterior=Variables.GetValueString(variable);
			//Texto Boton Anterior
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
			TextoBotonSiguiente=Variables.GetValueString(variable);
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "PreguntarAlCancelar";
			PreguntarAlCancelar = Variables.GetValueBool(variable);
		}
		public  bool AllowShow()
		{			
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public  ItemsDatasetErrors GetErrors()
		{
			
			return _errores;
		}

		public  string GetWarnings()
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

		//Siempre labura asi el execute
		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());
			this.IsValid();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion
		#region Miembros de IPersistentTask
		
		
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

	

		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.sy_Usuarios";			
			return replication;
		}

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
			 
		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();			
			return array;
		}
		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();			
			return data;
		}
		
	

		/// <summary>
		/// Envia el dataset e información adicional a la capa de acceso a datos para ejecutar la grabación de datos
		/// en el RDBM.
		/// </summary>
		
		public void Commit()
		{
			foreach (System.Data.DataRow _rowCat in _categoriasIva)
			{
				string categoriaIva=Convert.ToString(_rowCat["IdCategoriaIva"]);
			
				ArrayList desasociados=_tipoComprobanteCategoriaIva.ComprobantesDesasociados(categoriaIva);
				ArrayList asociados=_tipoComprobanteCategoriaIva.NuevosComprobantesAsociados(categoriaIva);
				//Los nuevos comprobantes asociados hay q ver si es una row nueva o ya estaba asociado pero no activo.
				
				foreach (TiposDeComprobantesView tcv in asociados)
				{
					string idTipoComprobante=tcv.IdTipoDeComprobante;
					tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow _row=tsy_TiposDeComprobantesCategoriaIva.GetByPk(idTipoComprobante,categoriaIva);
					if (_row!=null)
					{
						_row.Activo=true;
						_data.Tables[0].ImportRow(_row);
					}
					else
					{
						tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow _rowNueva=_data.tsy_TiposDeComprobantesCategoriaIva.Newtsy_TiposDeComprobantesCategoriaIvaRow();
						_rowNueva=tsy_TiposDeComprobantesCategoriaIva.SetRowDefaultValues(_rowNueva);
						_rowNueva.IdCategoriaIva=categoriaIva;
						_rowNueva.IdTipoDeComprobante=idTipoComprobante;
						_rowNueva.Activo=true;
						_data.Tables[0].Rows.Add(_rowNueva);	

					}
				}
				foreach (TiposDeComprobantesView tcv in desasociados)
				{
					string idTipoComprobante=tcv.IdTipoDeComprobante;
					tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow _row=tsy_TiposDeComprobantesCategoriaIva.GetByPk(idTipoComprobante,categoriaIva);
					// si ta _data.Tables[0].ImportRow(_row), si no _data.Tables[0].Rows.Add(_row);	
					_row.Activo=false;
					_data.Tables[0].ImportRow(_row);
				}
			
			}
		}
	
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			/*tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow _row=(tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow )_data.Tables[0].Rows[0];*/
			dataaccess.tsy_TiposDeComprobantesCategoriaIva.Update( (tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaDataTable) _data.Tables[0],trx);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region metodos privados
		private void Modificar()
		{
			ArrayList categoriaIva=this._todasCategoriasIva;
			_modificaciones=new ArrayList();
			//ArrayList resultados=new ArrayList();
			foreach (string cat in categoriaIva)
			{
				ArrayList asociados=this.Asociados(cat);
				foreach (EstadoObjeto eo in asociados)
				{
					string tipoComprobante=((TiposDeComprobantesView)eo.Objeto).IdTipoDeComprobante;
					if (eo.EsDeseleccionado())
					{
						ViewTipoComprobanteCategoriaIva obj=new ViewTipoComprobanteCategoriaIva(cat,tipoComprobante,"DELETE");
						_modificaciones.Add(obj);
					}
					else if (eo.EsSeleccionado())
					{
						ViewTipoComprobanteCategoriaIva obj=new ViewTipoComprobanteCategoriaIva(cat,tipoComprobante,"ADD");
						_modificaciones.Add(obj);
					}

				}
				if (ModificacionesHasChanged!=null)
				{
					ModificacionesHasChanged(this, new EventArgs());
				}
			}
			
		}
		#endregion
		#region metodos publicos
		//Devuelve todos los comprobantes con esa categoria, esten o no asociados
		public ArrayList Asociados(String categoria)
		{			return this._tipoComprobanteCategoriaIva.comprobantesDeCategoria(categoria);
		}

		
		public void AsociarNuevosComprobantes(ArrayList comprobantesSeleccionados,ArrayList comprobantesDeseleccionados)
        {
			this._tipoComprobanteCategoriaIva.Seleccionar(this.IdCategoriaIva,comprobantesSeleccionados);
			this._tipoComprobanteCategoriaIva.Deseleccionar(this.IdCategoriaIva,comprobantesDeseleccionados);
			this.Modificar();
		}
		public void EliminarDeGrilla(String idTipoCategoria,String idTipoComprobante)
		{
			ArrayList aux=this._tipoComprobanteCategoriaIva.comprobantesDeCategoria(idTipoCategoria);
			foreach (EstadoObjeto eo in aux){
						TiposDeComprobantesView tcv=(TiposDeComprobantesView)eo.Objeto;
				if (tcv.IdTipoDeComprobante.Equals(idTipoComprobante))
				{
					eo.Deshacer();
				}
				}
			this.Modificar();
			//Tiene q actualizar toda la vista
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}
		#endregion
		#region Eventos y delegados		
		public event System.EventHandler ModificacionesHasChanged;
		#endregion
		#region Clases Auxiliares
		private class TipoComprobanteCategoriaIva
		{
			public TipoComprobanteCategoriaIva()
			{
			
			
			}
			#region variables
			Hashtable _categorias=new Hashtable();
			#endregion
/// <summary>
/// Devuelve todos los tipos de comprobantes, tanto los asociados como no a esa categoria
/// </summary>
/// <param name="categoria"></param>
/// <returns></returns>
			public ArrayList comprobantesDeCategoria(string categoria)
			{
				return (ArrayList)_categorias[categoria];
			}

			public void asignarTodosTiposComprobantesCategoria(string categoria, ArrayList tipos)
			{
				ArrayList nuevo=tipos;
				_categorias.Add(categoria,nuevo);
			
			}
			/// <summary>
			/// Cambia de estado a persistido a aquellos q efectivamente estan asociados a la categoria de iva
			/// </summary>
			/// <param name="categoria"></param>
			/// <param name="tiposCategoria"></param>
			public void asignarTiposComprobantesCategoria(string categoria, ArrayList tiposCategoria)
			{
				ArrayList comprobantes=(ArrayList)_categorias[categoria];
				foreach (EstadoObjeto eo in comprobantes)
				{
					TiposDeComprobantesView tcw=(TiposDeComprobantesView)eo.Objeto;
					if (tiposCategoria.Contains(tcw.IdTipoDeComprobante))
					{
						eo.Persistir();
					}

				}
				this.comprobantesDeCategoria(categoria);
				
			}
		/// <summary>
		/// Le comunica al estado objeto q fue seleccionado, el de acuerdo a su estado determina su comportamiento
		/// </summary>
		/// <param name="idCategoria"></param>
		/// <param name="comprobantesSeleccionados"></param>
			public void Seleccionar(string idCategoria,ArrayList comprobantesSeleccionados)
			{
				if (idCategoria!="")
				{
					// Ver si esto funca o hay q hacerlo en la hastable, ver si el objeto en la has se modifica
					//ArrayList todos=(ArrayList)comprobantesDeCategoria(IdCategoriaIva);
					foreach (EstadoObjeto eo in comprobantesSeleccionados)
					{
						eo.Seleccionar();
					}
					this.comprobantesDeCategoria(idCategoria);
				}
			}
			/// <summary>
			/// Le comunica al estado objeto q fue deseleccionado, el de acuerdo a su estado determina su comportamiento
			/// </summary>
			/// <param name="idCategoria"></param>
			/// <param name="comprobantesDeseleccionados"></param>
			public void Deseleccionar(string idCategoria,ArrayList comprobantesDeseleccionados)
			{
				if (idCategoria!="")
				{
					// Ver si esto funca o hay q hacerlo en la hastable, ver si el objeto en la has se modifica
					//ArrayList todos=(ArrayList)comprobantesDeCategoria(IdCategoriaIva);
					foreach (EstadoObjeto eo in comprobantesDeseleccionados)
					{
						eo.Deseleccionar();
					}
				}
				this.comprobantesDeCategoria(idCategoria);
			}
			//Devuelve los tiposdeComprobantesView q deben agregarse con activo en 1
			public ArrayList NuevosComprobantesAsociados(string categoria)
			{
				ArrayList nuevo=new ArrayList();
				ArrayList todos=this.comprobantesDeCategoria(categoria);
				foreach( EstadoObjeto eo in todos)
				{
				 if (eo.EsSeleccionado())
					 nuevo.Add(eo.Objeto);
				}
				return nuevo;
			}
			public ArrayList ComprobantesDesasociados(string categoria)
			{
				ArrayList nuevo=new ArrayList();
				ArrayList todos=this.comprobantesDeCategoria(categoria);
				foreach( EstadoObjeto eo in todos)
				{
					if (eo.EsDeseleccionado())
						nuevo.Add(eo.Objeto);
				}
				return nuevo;
			}
		}
		public class ViewTipoComprobanteCategoriaIva
		{
			public  ViewTipoComprobanteCategoriaIva()
			{
							
			}
			public  ViewTipoComprobanteCategoriaIva(string idCategoriaIva,string idComprobante,string operacion){
				this.CategoriaIva=idCategoriaIva;
				this.Operacion=operacion;
				this.TipoComprobante=idComprobante;
			
			}
			#region variables
			private string categoriaIva=string.Empty;
			private string tipoComprobante=string.Empty;
			private string operacion=string.Empty;
			#endregion
			public string CategoriaIva
			{
				get{return categoriaIva;}
				set{categoriaIva=value;}
			}
			public string TipoComprobante
			{
				get{return tipoComprobante;}
				set{tipoComprobante=value;}
			}
			public string Operacion
			{
				get{return operacion;}
				set{operacion=value;}
			}
		
		}
			#endregion
	}
}
