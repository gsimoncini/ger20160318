using System;
using System.Data;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de GenerarClasesEntregas.
	/// </summary>
	public abstract class GenerateCollectionCommonTasks: ITask, IPersistentTask, IEnumerator, IEnumerable
	{
		public GenerateCollectionCommonTasks()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		protected ArrayList _clases = new ArrayList();
		protected virtual void AddTask(ITask _task)
		{
			_clases.Add( _task );
		}


		protected void Clear()
		{
			_clases.Clear();
		}

		
		#region Miembros de ITask

		public virtual event System.EventHandler ObjectHasChanged;

		public virtual event System.EventHandler OnTaskBeforeExecute;

		public virtual event System.EventHandler OnTaskAfterExecute;

		public virtual  event System.EventHandler OnTaskBeforePrevious;
		public virtual event System.EventHandler OnTaskAfterPrevious;

		public virtual void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public virtual void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación GenerarClasesEntregas.ListenerTaskDependentChanged
		}

		public virtual void ListenerAfterExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación GenerarClasesEntregas.ListenerAfterExecuteDependentTask
		}

		public virtual void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación GenerarClasesEntregas.ListenerBeforeExecuteDependentTask
		}
		public virtual void SpreadingListenerAfterExecuteDependentTask(object sender)
		{
			foreach (ITask _task in _clases)
			{
				_task.ListenerAfterExecuteDependentTask( sender );
			}
		}
		public virtual void SpreadingListenerBeforeExecuteDependentTask( object sender)
		{
			foreach (ITask _task in _clases)
			{
				_task.ListenerBeforeExecuteDependentTask( sender );
			}
		}
		public virtual void SpreadingListenerTaskDependentChanged( object sender)
		{
			foreach (ITask _task in _clases)
			{
				_task.ListenerTaskDependentChanged( sender );
			}
		}

		/*public virtual void ListenerAfterExecuteSubTask(object sender, System.EventArgs e) 
		{
			if (OnTaskAfterExecute != null)
			{
				this.OnTaskAfterExecute(this, new System.EventArgs());
			}
		}*/

		public void Init()
		{
			foreach (ITask _task in _clases)
			{
				_task.Init();
			}
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._process.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			bool isValid = true;
			int i=0;
			while ((isValid) || (i<_clases.Count))
			{
				if (((ITask)_clases[0]).IsValid())
				{
					isValid = false;
				}
				i++;
			}
			
			return isValid;
		}
		public bool AllowShow() 
		{
			return true;
		}		
		public void FormHasClosed() 
		{
		}
		ItemsDatasetErrors _errores = new ItemsDatasetErrors();

		public ItemsDatasetErrors GetErrors()
		{
			_errores.Clear();
			foreach(ITask _task in _clases)
			{
				_errores.AddAll( _task.GetErrors());
			}
			return _errores;
		}

		public string GetWarnings()
		{			
			return null;
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _process;
			
		}
		protected ProcessManager _process;
		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_process = processManager;
		}

		public string GetTaskName()
		{
			// TODO: agregar la implementación GenerarClasesEntregas.GetTaskName
			return _taskName;
		}
		protected string _taskName = string.Empty;

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public virtual void Execute()
		{
			
			/*Deprecated hasta q las tareas generadas automaticamente se puedan insertar el proceso*/
			/*
			foreach (ITask _task in _clases)
			{
				_task.Execute();
			}
			*/
			if (OnTaskBeforeExecute != null)
			{
				OnTaskBeforeExecute( this, new System.EventArgs());
			}
			if (OnTaskAfterExecute != null)
			{
				OnTaskAfterExecute( this, new System.EventArgs() );
			}
	
		}

		#endregion

		#region Miembros de IPersistentTask

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
		public virtual event System.EventHandler OnTaskBeforeFlush;
		public virtual event System.EventHandler OnTaskAfterFlush;
		
		public System.Collections.ArrayList GetDataList()
		{
			ArrayList _array = new ArrayList();
			/*
			foreach (IPersistentTask _task in _clases)
			{
				ArrayList _subarray = _task.GetDataList();
				foreach (DataSet _data in _subarray )
				{
					_array.Add( _data );
				}
			}
			*/
			return _array;
		}

		public TaskCollectionData GetData()
		{
			TaskCollectionData _taskCollection = new TaskCollectionData();
			if (_clases.Count > 0)
			{
				_taskCollection.TaskName = ((IPersistentTask)_clases[0]).GetData().TaskName;
			}
			for (int i=1;i<_clases.Count;i++)
			{
				//ArrayList _array = ((IPersistentTask)_clases[i]).GetData();
				foreach(DataSet _data in  ((IPersistentTask)_clases[i]).GetData())
				{
					if (_data != null)
					{
						_taskCollection.Add( _data );
					}
				}
			}
			return _taskCollection;
		}

		public void Commit()
		{
			foreach (IPersistentTask _task in _clases)
			{
				_task.Commit();
			}
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this, new EventArgs());
			foreach (IPersistentTask _task in _clases)
			{
				_task.Flush( IdTransaction );
			}
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			foreach (IPersistentTask _task in _clases)
			{
				_task.PutExtraData( _processCollectionData );
			}
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			foreach (IPersistentTask _task in _clases)
			{
				_task.PutExtraDataOnCommit( _processCollectionData );
			}
		}	

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion _sentencia = null;
			if (_clases.Count > 0)
			{
				_sentencia = ((IPersistentTask)_clases[0]).GetSentenceReplication();
			}

			for(int i=1;i<_clases.Count;i++)
			{
				_sentencia.Sentence.Append( ((IPersistentTask)_clases[i]).GetSentenceReplication().Sentence );
			}
			return _sentencia;
		}
		


		#endregion

		#region Miembros de IEnumerator
		private int index = -1;
		public void Reset()
		{
			index = -1;
		}

		public object Current
		{
			get
			{
				return (object)this._clases[index];
				
			}
		}
		public bool MoveNext()
		{
			if (index+1 < (this._clases.Count-1))
			{
				index++;
				return true;
			}
			else
				return false;
		}

		#endregion

		#region Miembros de IEnumerable

		public IEnumerator GetEnumerator()
		{
			return this._clases.GetEnumerator();
		}

		#endregion
	}
}
