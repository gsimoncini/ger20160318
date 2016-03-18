using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Task.
	/// </summary>
	public class Process
	{
		
		#region Construcutores

		public Process()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#endregion

		#region Variables Privadas

		private long _idProcess = long.MinValue;
		private string _processName = string.Empty;
		private bool _checkValidOnStart = false;
		private bool _checkValidOnEnd = false;
		private TaskDynamicInfo _mainTask;
		private ArrayList _secondaryTasks = new ArrayList();
		

		#endregion

		#region Variables Publicas


		public bool CheckValidOnStart
		{
			get{return _checkValidOnStart;}
			set{_checkValidOnStart = value;}
		}

		public bool CheckValidOnEnd
		{
			get{return _checkValidOnEnd;}
			set{_checkValidOnEnd = value;}
		}

		public string ProcessName
		{
			get
			{
				return _processName;
			}
			set
			{
				_processName = value;
			}
		}

		public long IdProcess
		{
			get
			{
				return _idProcess;
			}
			set
			{
				_idProcess = value;
				GetPrimaryTask();
				GetSecondaryTasks();
			}
		}

		public TaskDynamicInfo MainTask
		{
			get
			{
				return _mainTask;
			}

		}
		
		public ArrayList SecondaryTasks
		{
			get
			{
				return _secondaryTasks;
			}

		}

	
			
		#endregion

		#region Metodos Privados
		private void GetPrimaryTask()
		{
			System.Data.DataSet data  = Workflow.GetProcessPrimaryTask(this._idProcess);
			if(data.Tables.Count > 0)
				if(data.Tables[0].Rows.Count > 0)
				{
					System.Data.DataRow row = data.Tables[0].Rows[0];
					long IdPrimaryTask = Convert.ToInt64(row["IdTarea"]);
					int order = Convert.ToInt32(row["Orden"]);
					int orderBR = Convert.ToInt32(row["OrdenBR"]);
					int orderDA = Convert.ToInt32(row["OrdenDA"]);
					int orderUI = Convert.ToInt32(row["OrdenUI"]);
					this._mainTask = this.GetTaskDynamicInfo(IdPrimaryTask,order,orderBR,orderDA, orderUI);
				}
		}
			
		private void GetSecondaryTasks()
		{
			
			System.Data.DataSet data = Workflow.GetProcessSecondaryTasks(this._idProcess);
			foreach(System.Data.DataRow row in data.Tables[0].Rows)
			{
				long IdSecondaryTask = Convert.ToInt64(row["IdTarea"]);
				int order = Convert.ToInt32(row["Orden"]);
				int orderBR = Convert.ToInt32(row["OrdenBR"]);
				int orderDA = Convert.ToInt32(row["OrdenDA"]);
				int orderUI = Convert.ToInt32(row["OrdenUI"]);
				TaskDynamicInfo taskDynInfo = this.GetTaskDynamicInfo(IdSecondaryTask, order, orderBR,orderDA, orderUI);
				if (taskDynInfo.Type != null)
				{
					_secondaryTasks.Add(taskDynInfo);
				}
			}
			
		}

		private TaskDynamicInfo GetTaskDynamicInfo(long IdTask, int order, int orderBR, int orderDA, int orderUI)
		{
			TaskDynamicInfo taskDynInfo = new TaskDynamicInfo();
			taskDynInfo.IdTask = IdTask;
			taskDynInfo.Order = order;
			taskDynInfo.OrderBR = orderBR;
			taskDynInfo.OrderDA = orderDA;
			taskDynInfo.OrderUI = orderUI;
			taskDynInfo.Type = TaskStaticInfo.GetTaskType(taskDynInfo.KeyTask);
			return taskDynInfo;
		}

		#endregion

	}
}
