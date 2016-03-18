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
	/// Descripción breve de AbmBonificaciones.
	/// </summary>
	public class AbmBonificaciones:ITask, IPersistentTask
	{
		public AbmBonificaciones()
		{
			_bonificacion=new  mz.erp.businessrules.comprobantes.Bonificacion();
		}

		#region Variables Privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		private mz.erp.businessrules.comprobantes.Bonificacion _bonificacion;
		private mz.erp.commontypes.data.tsa_BonificacionesDataset data=new mz.erp.commontypes.data.tsa_BonificacionesDataset();
		private string _textoBotonSiguiente = "Guardar";
		private string _leyenda="Abm Bonificaciones";
		private string _operacion=string.Empty;
		private Hashtable _bonificaciones= new Hashtable();
		
		//Variables para la busqueda
		private string _tipoBonificacionEdicion=string.Empty;
		private string _codigoEdicion=string.Empty;
		
		#endregion
		#region propiedades
		public event EventHandler BonificacionesDetalleHasChanged;
		public event EventHandler TipoBonificacionHasChanged;
		public event EventHandler CodigoHasChanged;
		public event EventHandler DescripcionHasChanged;
		public event EventHandler TipoBonificacionEdicionHasChanged;
		public event EventHandler CodigoEdicionHasChanged;
		public event EventHandler MaximoHasChanged;
		public event EventHandler MinimoHasChanged;
		public event EventHandler ValorHasChanged;
		
		public ArrayList BonificacionesDetalle
		{
			get {return _bonificacion.BonificacionesDetalle;}
			set{_bonificacion.BonificacionesDetalle=value;}
		}
		public System.Data.DataTable Codigos
		{
			get {return this.CodigosEdicion();}
			
		}
		
		public string TipoBonificacion
		{
			get {return _bonificacion.TipoBonificacion;}
			set{_bonificacion.TipoBonificacion=value;}
			
		}
		public string TipoBonificacionEdicion
		{
			get {return _tipoBonificacionEdicion;}
			set
			{
			if (_tipoBonificacionEdicion!=value)
				{
					_tipoBonificacionEdicion= value;
					if (TipoBonificacionEdicionHasChanged!=null)
						TipoBonificacionEdicionHasChanged(this, new EventArgs());
				}
			}
	}
		
		public string Codigo
		{
			get {return _bonificacion.Codigo;}
			set
			{
				if (_bonificacion.Codigo!=value)
				{
					_bonificacion.Codigo= value;
					if (CodigoHasChanged!=null)
						CodigoHasChanged(this, new EventArgs());
				}
				
			}
		}
		public string CodigoEdicion
		{
			get {return _codigoEdicion;}
			set
			{
				if (_codigoEdicion!=value)
				{
					_codigoEdicion= value;
					if (CodigoEdicionHasChanged!=null)
						CodigoEdicionHasChanged(this, new EventArgs());
				}
			}
		}
		
		
		public string Descripcion
		{
			get {return _bonificacion.Descripcion;}
			set
			{
				if (_bonificacion.Descripcion!=value)
				{
					_bonificacion.Descripcion= value;
					if (DescripcionHasChanged!=null)
						DescripcionHasChanged(this, new EventArgs());
				}
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
		public string Operacion
		{
			get
			{
				return _operacion;
			}
			set
			{
				_operacion = value;
			}
		}

		public BonificacionItem SelectedItem
		{
			get{return _bonificacion.SelectedItem;}
			set
			{
				BonificacionItem item = (BonificacionItem) value;
				if(_bonificacion.SelectedItem != item)
				{
					_bonificacion.SelectedItem = item;
					if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
				}
				}
		}
		public decimal Maximo
		{
			get{return _bonificacion.Maximo;}
			set{Decimal valor=Convert.ToDecimal(value);
				
				if (_bonificacion.Maximo!=valor){
				_bonificacion.Maximo=valor;
				if(MaximoHasChanged!=null)
					MaximoHasChanged(this, new EventArgs());}
			}
		}
		public decimal Minimo
		{
			get{return _bonificacion.Minimo;}
			set{Decimal valor=Convert.ToDecimal(value);
				
				if (_bonificacion.Minimo!=valor)
				{
					_bonificacion.Minimo=valor;
					if (MinimoHasChanged!=null)
						MinimoHasChanged(this, new EventArgs());
				}
				}
		}
        //German 20120208 - Tarea 0000276
		public decimal Valor
		{
			get{return _bonificacion.Valor;}
			set{decimal valor= value;
				if (_bonificacion.Valor!=valor)
				{
					_bonificacion.Valor=valor;
					if (ValorHasChanged!=null)
							ValorHasChanged(this, new EventArgs());
				}
				}
		}
        //German 20120208 - Tarea 0000276
		
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
			ValidarDatos();
			if (_errores.Count > 0)
				return false;
			else
				return true;
		}



		// Levanta la inicializacion de la tarea
		public  void Init()

		{  this._bonificacion.BonificacionesDetalleHasChanged+=new EventHandler(_bonificacion_BonificacionesDetalleHasChanged);
			//this._bonificacion.CodigoHasChanged+=new EventHandler(_bonificacion_CodigoHasChanged);
			//this._bonificacion.DescripcionHasChanged+=new EventHandler(_bonificacion_DescripcionHasChanged);
			this._bonificacion.TipoBonificacionHasChanged+=new EventHandler(_bonificacion_TipoBonificacionHasChanged);
			
			//Para ver si es el alta o la modificacion
            //German 20120208 - Tarea 0000276
			//string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "Operacion";
			//Operacion =Variables.GetValueString(variable);
            if (this._processParent.Process.ProcessName.Equals("ProcesoAbmBonificaciones"))
                Operacion = "new";
            else
                Operacion = "edit";

            string variable = string.Empty;
            //German 20120208 - Tarea 0000276
			
			//Leyenda del formulario
            //German 20120208 - Tarea 0000276
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
            //German 20120208 - Tarea 0000276
			Leyenda = Variables.GetValueString(variable);
				
			variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
			this.TextoBotonSiguiente= Variables.GetValueString(variable);	
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
		//Variable mia
		
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
			_bonificacion.Commit();
						
		}
	
	
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();
			_bonificacion.Flush(IdTransaction);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		#region metodos publicos
		public void NuevoDetalle( )
		{
			this.SelectedItem=_bonificacion.NuevoDetalle();
		}
		public void AgregarDetalleActual()
		{
			_bonificacion.AgregarDetalleActual();
		}

		public bool ItemValido( )
		{
			bool ok=_bonificacion.ItemValido(this.Maximo,this.Minimo);
			if (!ok){
			_errores.Clear();
			_errores.Add( new ItemDatasetError( "Bonificación","Item","No se puede agregar el detalle de la bonificación, pues hay otro detalle cuyos valores se superponen") );}
			else
				_bonificacion.AgregarDetalleActual();
			return ok;
			
		}

		public void EliminarBonificacionDetalle(BonificacionItem bonif)
		{
			 
			_bonificacion.EliminarBonificacionDetalle(bonif);
			
		}
		
		public string ContenedoresVisibles()
		{
			if (this.Operacion.Equals("new"))
				return "DatosGenerales";
			else 
				return "DatosBonificacion";
		}

		public System.Data.DataTable CodigosEdicion(){
		//Traigo todas las bonificaciones para ese tipo de bonificacion
		tsa_BonificacionesDataset bonif =tsa_Bonificaciones.GetList(null,null,this.TipoBonificacionEdicion,null);
		if (bonif.Tables[0].Rows.Count!=0){
			foreach (tsa_BonificacionesDataset.tsa_BonificacionesRow row in bonif.Tables[0].Rows){
				_bonificaciones[Convert.ToString(row["Codigo"])]=row;
			}
			}
			return (System.Data.DataTable)bonif.Tables[0];	
		
		}
		public void SeleccionarBonificacion(){
			
			tsa_BonificacionesDataset.tsa_BonificacionesRow datos=(tsa_BonificacionesDataset.tsa_BonificacionesRow)_bonificaciones[this.CodigoEdicion];
			this._bonificacion.IdBonificacion=Convert.ToString(datos["IdBonificacion"]);
			this._bonificacion.Codigo=Convert.ToString(datos["Codigo"]);
			this._bonificacion.Descripcion=Convert.ToString(datos["Descripcion"]);
			this._bonificacion.TipoBonificacion=Convert.ToString(datos["IdTipoBonificacion"]);
			//Buscamos los detalles para la bonificacion
			ArrayList detalles =this._bonificacion.BuscarDetalles();
			this._bonificacion.BonificacionesDetalle=detalles;
			
		}

		public void ResetearBonificacion()
		{
			this._bonificacion.IdBonificacion=string.Empty;
			this.Descripcion=string.Empty;
			this.Codigo=string.Empty;
			this._bonificacion.BonificacionesDetalle=new ArrayList();
		}
		#endregion
		#region metodos privados
		private void _bonificacion_BonificacionesDetalleHasChanged(object sender, EventArgs e)
		{
			if (BonificacionesDetalleHasChanged!=null)
				BonificacionesDetalleHasChanged(this, new EventArgs());
		}

		/*private void _bonificacion_CodigoHasChanged(object sender, EventArgs e)
		{
			if (CodigoHasChanged!=null)
				CodigoHasChanged(this, new EventArgs());
		}

		private void _bonificacion_DescripcionHasChanged(object sender, EventArgs e)
		{
			if(DescripcionHasChanged!=null)
				DescripcionHasChanged(this, new EventArgs());
		}*/

		private void _bonificacion_TipoBonificacionHasChanged(object sender, EventArgs e)
		{
			if(TipoBonificacionHasChanged!=null)
				TipoBonificacionHasChanged(this, new EventArgs());
		}

		private void ValidarDatos(){
		  //Esta actualizando y no selecciono una bonificacion
			if(this._bonificacion.IdBonificacion.Equals(string.Empty)&& !this.Operacion.Equals("new"))
				_errores.Add( new ItemDatasetError( "Bonificación","Bonificación","No ha seleccionado ninguna bonificación para editar") );
			else
			{
				string _descripcion=_bonificacion.Descripcion;
				_errores.Clear();
				if (_descripcion.CompareTo(string.Empty) == 0)
				{
					_errores.Add( new ItemDatasetError( "Bonificación","Descripción","El campo no puede estar vacío") );
				}
				string _codigo=_bonificacion.Codigo;
				if (_codigo.CompareTo(string.Empty) == 0)
				{
					_errores.Add( new ItemDatasetError( "Bonificación","Código","El campo no puede estar vacío") );
				}
                else 
				{
					if (this._bonificacion.IdBonificacion.Equals(string.Empty))
					{
						//Si bien es getList el codigo se compara por =
						tsa_BonificacionesDataset data =tsa_Bonificaciones.GetList(null, null, null, _codigo);
						if (data.Tables[0].Rows.Count!=0)
							_errores.Add( new ItemDatasetError( "Bonificación","Código","Ya existe otra bonificación con ese código") );
					}
					else
					{
						//Si es modificacion tengo q ver por codigo + idbonificacion, si el codigo coincide pero el idbonificacion no=> error ya existe codigo
						tsa_BonificacionesDataset data =tsa_Bonificaciones.GetList(null, null, null, _codigo);
						if (data.Tables[0].Rows.Count!=0)
							foreach(tsa_BonificacionesDataset.tsa_BonificacionesRow row in  data.Tables[0].Rows)
							{
								if (!Convert.ToString(row["idBonificacion"]).Equals(this._bonificacion.IdBonificacion))
									_errores.Add( new ItemDatasetError( "Bonificación","Código","Ya existe otra bonificación con ese código") );
							}
					}
				
				}
                
				string _tipobonificacion=_bonificacion.TipoBonificacion;
				if (_tipobonificacion.CompareTo(string.Empty) == 0)
				{
					_errores.Add( new ItemDatasetError( "Bonificación","Tipo bonificacion","Debe seleccionar un tipo para la bonificación") );
				}
				ArrayList detalles=_bonificacion.BonificacionesDetalle;
				foreach(BonificacionItem item in detalles)
				{ //Si es 0 el usuario no cargo nada, asi q se guardara como decimal.maxvalue
					if (item.Maximo!=0)
						if (item.Minimo>=item.Maximo)			
							_errores.Add( new ItemDatasetError( "Bonificación","Máximo","No puede ser menor el valor máximo que el mínimo en el detalle de la bonificación") );
					bool ok=_bonificacion.ItemValido(item);
					if (!ok)
					{
						_errores.Add( new ItemDatasetError( "Bonificación","Item","Verifique los detalles de la bonificación, pues hay mas de un detalle cuyos valores se superponen") );
					}
					}
			
		
			}
			
			
		}
		#endregion
	}
	
}
