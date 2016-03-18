using System;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Agrupamientos.
	/// </summary>
	public abstract class Agrupamientos: ITask , IPersistentTask
	{

		#region Constructores

		public   Agrupamientos()
		{
			
		}

		#endregion

		#region variables privadas

			private  string _uiClass;
			private string _uiClassAgrupamientos;
			private ArrayList _fieldsLayout = new ArrayList();
			protected ProcessManager _processParent = null;
			protected string _taskName = null;
			protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
			protected bool _allowShow = true;
			private IList _elementos;
			private string _jerarquia = string.Empty;
			private string _idNomenclatura = string.Empty;
		

			

		#endregion

		#region Propiedades

		protected string Jerarquia
		{
			get{return _jerarquia;}
			set{_jerarquia = value;}
		}

		
		protected string IdNomenclatura
		{
			get{return _idNomenclatura;}
			set{_idNomenclatura = value;}
		}


		
		public  IList Elementos
		{
			get
			{
				return _elementos;
			}
		}

		public string UIClass
		{
			get
			{
				return _uiClass;
			}
			
		}

		public ArrayList FiledsLayout
		{
			get
			{
				return _fieldsLayout;
			}
		}

		public string UIClassAgrupamientos
		{
			get
			{
				return _uiClassAgrupamientos;
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
		public virtual void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public virtual void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public virtual void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public virtual bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public  void Init()
		{
			_fieldsLayout = this.GetFields();
			_uiClass = this.GetUIClass();
			_uiClassAgrupamientos = this.GetUIClassAgrupamientos();
			InitializeData();
		}



		public virtual bool AllowShow()
		{			
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public virtual ItemsDatasetErrors GetErrors()
		{
			
			return _errores;
		}

		public virtual string GetWarnings()
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
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());
			this.IsValid();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		#endregion

				
		#region Template and Abstract Methods

		public  void UpdateElementos(ArrayList rows)
		{
			ProcesarElementos(rows);
			Refresh();

			
		}

		public void Add(string key)
		{
			GetJerarquia(key);
			/*
			if(IsValid())
			{
				RelacionarJerarquiaElementos();
			}
			*/
			if(IsValid())
			{
				Commit();
				Flush(null);
			}
			
		}

	
		public abstract string GetUIClass();
		public abstract ArrayList GetFields();
		public abstract Node getChildsNode(string key);
		public abstract string GetUIClassAgrupamientos();
		public abstract void ProcesarElementos(ArrayList rows);
		public abstract void GetJerarquia(string key);
		public abstract void RelacionarJerarquiaElementos();
		public abstract void Commit();
		public abstract void Flush(string IdTransaction);
		public abstract bool IsValid();
		public abstract void InitializeData();
		public abstract TaskCollectionData GetData();
		public abstract mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication();
		public abstract DataTable SearchAgrupamientos(object target);
		public abstract void DeleteAgrupamientos(string Jerarquia);
		//Cristian Tarea 00084 20120109
        //Agrega un proveedor o cliente a los items 
        public virtual void Agregar(String codigo) { }
        //Fin Cristian
		public void Refresh()
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		protected void SetElementos(IList elems)
		{
			_elementos = elems;
		}

			

			

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public virtual void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData){}
		public virtual void PutExtraData(ProcessCollectionData _processCollectionData){}
		public virtual  bool GetHasSaved(){return false;}

		
		#endregion
	}
}
