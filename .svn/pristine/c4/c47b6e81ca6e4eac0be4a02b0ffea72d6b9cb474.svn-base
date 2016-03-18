using System;
using System.Reflection;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.dataaccess;
using System.Data;
using System.Text;
//using System.Web.Mail;
using mz.erp.security;
using System.Net.Mail;
using System.Net.Mime;



namespace mz.erp.businessrules
{
	/// <summary>
	/// Esta clase tiene como objetivo manejar las tareas a nivel de capa de negocios.
	/// El constructor de esta clase recibe como parametro el IdTarea a generar, y los parametroas 
	/// de inicializacion para dichha tarea y sus subtareas.
	/// Esta clase maneja la parte dinamica de las tareas.
	/// </summary>
	public class ProcessManager
	{
		public event System.EventHandler OnProcessMessageChanged;
		public event System.EventHandler OnProgressCounterChanged;
		//public event System.EventHandler OnProcessHadProblems;
		public delegate void OnNextTaskHandler(string keyTask);
		public delegate void OnPreviousTaskHandler(string keyTask);
		public delegate void OnEndProcessHandler(string keyTask);
		public delegate void OnProcessErrorsHandler(string keyTask);
		public delegate void OnProcessErrorsOnStartHandler(ItemsDatasetErrors errors);
		public delegate void OnProcessWarningsHandler(string keyTask);
		public delegate void OnProcessErrorFlushHandler(string keyTask, string mensaje, ItemsDatasetErrors flushErrors);

		public event OnNextTaskHandler OnNextTask;		
		public event OnPreviousTaskHandler OnPreviousTask;
		public event OnEndProcessHandler OnEndProcess;
		public event OnProcessErrorFlushHandler OnErrorFlushProcess;
		public event OnProcessErrorsHandler OnProcessErrors;
		public event OnProcessErrorsOnStartHandler OnProcessErrorsOnStart;
		public event OnProcessWarningsHandler OnProcessWarnings;
		

		

		#region Constructores
		public ProcessManager( )
		{

		}
		public void CreateNewProcess( string _processName, Hashtable parametros )
		{
			_message = "Iniciando Proceso "+ _processName;
			_parametros = parametros;
			_process = new Process();
			long IdProcess = mz.erp.businessrules.Workflow.GetIdProcessByName( _processName );
			_process.IdProcess = IdProcess;
			_process.ProcessName = _processName;
			
			DataRow row = mz.erp.businessrules.twf_Procesos.GetByPk(IdProcess);
			if(row != null)
			{
				_process.CheckValidOnStart = Convert.ToBoolean(row["ValidaAlIniciar"]);
				_process.CheckValidOnEnd = Convert.ToBoolean(row["ValidaAlFinalizar"]);
			}
			Init();
			
		}
		#endregion

		#region Variables Privadas
		private Process _process = null;
		private ArrayList _arrayDataSet = new ArrayList();
		private int _tasksExecutedCount = 0;
		private bool _processFlushed = false;
		private bool _isValidBackState = false;

		private string _message = string.Empty;
		private int _tasks = 0;
		private int _processProgress = 0;
		private int _processProgressTop = 100;
		private ProcessState.State _state = ProcessState.State.StartState;
		private string _errorMessage = "";
        //Cristian Tarea 0000051 20110407
        private Hashtable _managerFilters = new Hashtable();
        //Fin Cristian 20110407
		#endregion

		#region propiedades


		public bool IsValidBackState
		{
			get
			{	if(_process.MainTask.TaskInstance is IPersistentTask)
					_isValidBackState=true;
				foreach(TaskDynamicInfo secondaryTaskInfo in _process.SecondaryTasks)
				{
					if(secondaryTaskInfo.TaskInstance is IPersistentTask)
						_isValidBackState=true;
				}
					return _isValidBackState;
				}
			set
			{
				_isValidBackState= value;
			}
		}
		
		#endregion

		#region Variables Publicas
		
		public string ProcessMessage
		{
			get { return this._message ; }
		}
		public int ProgressCounter
		{
			get { return this._processProgress; }
		}
		public int ProgressCounterTop
		{
			get { return this._processProgressTop; }
		}
		public Process Process
		{
			get
			{
				return _process;
			}
		}
		public bool IsPersistentProcess
		{
			get { return (this._tasksBeforeFlush.Count > 0); }
		}
		public bool ProcessFlushed
		{
			get {return _processFlushed ; }
		}

		public bool ValidBackState
		{
			get {return IsValidBackState; }
		}
		public bool AskRecallProcess
		{
			get 
			{
				return Variables.GetValueBool( this._process.ProcessName + ".PreguntarRecargarProceso" );
			}
		}
		public bool RecallProcess
		{
			get 
			{
				return Variables.GetValueBool( this._process.ProcessName + ".RecargarProceso" );
			}
		}
        //Cristian Tarea 0000145 20110601
        /* Propiedad para mostrar el cartel de exito al finalizar los procesos */
        public bool ShowMessageEndProcess
        {
            get
            {
                return Variables.GetValueBool(this._process.ProcessName + ".MostrarFinDeProceso", "Sistema.MostrarFinDeProceso");
            }
        }
        //Fin Cristian Tarea 0000145
		private Hashtable _parametros;
		public Hashtable Parametros
		{
			get {return _parametros;}
		}


	    
		private bool _mostroWarnings = false;
		public bool MostroWarnings
		{
			get{return _mostroWarnings;}
			set{_mostroWarnings = value;}
		}



		#endregion
		
		#region Metodos Privados
		private void AddMainTask()
		{
			SetProgress( 10 );
			TaskDynamicInfo _mainClassInfo = GetPrimaryTask();
			SetMessage( "Iniciando "+_mainClassInfo.KeyTask );
			Type _mainTaskType = _mainClassInfo.Type;
			_mainClassInfo.TaskInstance = Activator.CreateInstance(_mainTaskType);
		}

		private void AddSecondaryTask()
		{	
			ArrayList secondaryTasks = GetSecondaryTasks();
			int qTasks=secondaryTasks.Count;
			int current=0;
			foreach(TaskDynamicInfo taskDynInfo in secondaryTasks)
			{
				if (taskDynInfo.Type != null)
				{
					SetMessage( "Iniciando "+taskDynInfo.KeyTask );
					object _secondaryInstance = Activator.CreateInstance(taskDynInfo.Type);
					taskDynInfo.TaskInstance = _secondaryInstance;
					current++;
					SetProgress( Convert.ToInt64(  (current * 100/qTasks)* 0.8 ) );  
				}
			}			
		}
	
		private ArrayList GetSecondaryTasks()
		{
			return _process.SecondaryTasks;
		}

		private TaskDynamicInfo GetPrimaryTask()
		{
			return  _process.MainTask;
		}
		

		private ArrayList SortTasks(TaskStaticInfo.SortOrder sortOrder)
		{
			ArrayList result = new ArrayList();
			result.Add(this._process.MainTask);
			result.AddRange(this._process.SecondaryTasks);
			switch (sortOrder )
			{
				case TaskStaticInfo.SortOrder.OrderBR:
				{
					result.Sort(TaskDynamicInfo.SortByOrderBRInstance);
				}
				break;
				case TaskStaticInfo.SortOrder.OrderDA:
				{
					result.Sort(TaskDynamicInfo.SortByOrderDAInstance);
				}
				break;
				case TaskStaticInfo.SortOrder.OrderUI:
				{
					result.Sort(TaskDynamicInfo.SortByOrderUIInstance);
				}
				break;
				default: result.Sort();
					break;

			}
			
			return result;
		}


		private void CallClassInit()
		{	
			
			ITask taskInstance = (ITask) _process.MainTask.TaskInstance;
			taskInstance.SetTaskName( _process.MainTask.KeyTask );
			taskInstance.SetProcessManagerParent( this );
			DateTime fecha = DateTime.Now;
			taskInstance.Init();
            //Cristian Tarae 0000051 20110411

            //Sistema.AddValueFilter(Process.ProcessName, Process.MainTask.KeyTask, "FechaDesde", "222");
            //Fin Cristian Tarea 0000051 20110411
			foreach(TaskDynamicInfo secondaryTask in _process.SecondaryTasks)
			{
				taskInstance = (ITask) secondaryTask.TaskInstance;
				taskInstance.SetTaskName( secondaryTask.KeyTask );
				taskInstance.SetProcessManagerParent( this );
				 fecha = DateTime.Now;
				taskInstance.Init();
			}
		}

		private MethodBase FindMethodByName(Type classType, string methodName)
		{
			return classType.GetMethod(methodName);
		}

		private MethodBase FindMethodByAttribute(Type classType, Type attrib)
		{		
			foreach(MethodBase mb in classType.GetMethods())
			{
				foreach(Attribute am in mb.GetCustomAttributes(false))
				{
					if(am.GetType().Equals(attrib))
						return  mb;
				}
			}
			return null;	
		}
        //Cristian tarea 0000051 20110411
        private Attribute FindAttributeByName(Type classType, String name)
        {
            foreach (Attribute attribute in classType.GetCustomAttributes(false))
            {
                if (attribute.Equals("FechaDesde"))
                { return attribute; }
            }
            return null;
        }
        //Fin Cristian tarea 0000051

		void InitEvents()
		{
			ITask mainTask = (ITask) _process.MainTask.TaskInstance;
			mainTask.ObjectHasChanged +=new EventHandler(ListenerTaskChangesEvent);
			mainTask.OnTaskAfterExecute+= new EventHandler(ListenerAfterExecuteDependentTask);
			mainTask.OnTaskBeforeExecute+= new EventHandler( ListenerBeforeExecuteDependentTask );
			/*Por ahora se cuelga solo del evento OnTaskAfterPrevious*/
			mainTask.OnTaskAfterPrevious+= new EventHandler(ListenerAfterPreviousDependentTask);
			if(_process.MainTask.TaskInstance is IPersistentTask)
			{
				IPersistentTask persistentTask = (IPersistentTask)_process.MainTask.TaskInstance;
				persistentTask.OnTaskAfterFlush +=new EventHandler(ListenerTaskAfterFlush);
				persistentTask.OnTaskBeforeFlush +=new EventHandler(ListenerTaskBeforeFlush);
			}
			foreach(TaskDynamicInfo secondaryTaskInfo in _process.SecondaryTasks)
			{
				ITask secondaryTaskInstance = (ITask)secondaryTaskInfo.TaskInstance;
				secondaryTaskInstance.ObjectHasChanged +=new EventHandler(ListenerTaskChangesEvent);
				secondaryTaskInstance.OnTaskAfterExecute += new EventHandler( ListenerAfterExecuteDependentTask );
				secondaryTaskInstance.OnTaskBeforeExecute += new EventHandler( ListenerBeforeExecuteDependentTask);
				/*Por ahora se cuelga solo del evento OnTaskAfterPrevious*/
				secondaryTaskInstance.OnTaskAfterPrevious+= new EventHandler(ListenerAfterPreviousDependentTask);
				if(secondaryTaskInfo.TaskInstance is IPersistentTask)
				{
					IPersistentTask secondaryTask = (IPersistentTask)secondaryTaskInfo.TaskInstance;
					secondaryTask.OnTaskAfterFlush +=new EventHandler(ListenerTaskAfterFlush);
					secondaryTask.OnTaskBeforeFlush +=new EventHandler(ListenerTaskBeforeFlush);
				}				
			}
		}

		public void GetParameters(object sender, string Tarea) 
		{
			if (_parametros != null) 
			{
				mz.erp.commontypes.ProcessParameters.GetInitialParameters(sender, Tarea, _parametros);				
			}
		}

		private void ListenerAfterPreviousDependentTask(object sender, EventArgs e)
		{
			
			ArrayList tasks = this.SortedTasks(TaskStaticInfo.SortOrder.OrderBR);
			foreach (TaskDynamicInfo task in tasks)
			{
				ITask taskDependent = (ITask) task.TaskInstance;
				taskDependent.ListenerAfterPreviousDependentTask(sender);
				
			}
			ITask previousTask = this.PreviousTask();
			if(previousTask != null)
			{
				this._state = ProcessState.State.BackState;
				if(OnPreviousTask != null)
					OnPreviousTask(previousTask.GetTaskName());
			}
		}

		private void ListenerTaskBeforeFlush(object sender, EventArgs e)
		{
			ArrayList tasks = this.SortedTasks(TaskStaticInfo.SortOrder.OrderDA);
			foreach (TaskDynamicInfo task in tasks)
			{
				if(task.TaskInstance is IDependentPersistentTask)
				{
					IDependentPersistentTask taskDependent = (IDependentPersistentTask) task.TaskInstance;
					taskDependent.ListenerBeforeFlush(sender);
				}
			}
		}

		private void ListenerTaskAfterFlush(object sender, EventArgs e)
		{
		}

		void ListenerTaskChangesEvent(object sender, System.EventArgs e)
		{
			ITask mainTask = (ITask) _process.MainTask.TaskInstance;
			mainTask.ListenerTaskDependentChanged(sender);
			foreach(TaskDynamicInfo secondaryTaskInfo in _process.SecondaryTasks)
			{
				ITask secondaryTaskInstance = (ITask)secondaryTaskInfo.TaskInstance;
				secondaryTaskInstance.ListenerTaskDependentChanged(sender);
			}
		}

		/// <summary>
		/// se ejecutara antes de iniciar una tarea
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ListenerBeforeExecuteDependentTask(object sender, System.EventArgs e)
		{//ST
			ITask mainTask = (ITask) _process.MainTask.TaskInstance;
			mainTask.ListenerBeforeExecuteDependentTask(sender);
			foreach(TaskDynamicInfo secondaryTaskInfo in _process.SecondaryTasks)
			{
				ITask secondaryTaskInstance = (ITask)secondaryTaskInfo.TaskInstance;
				secondaryTaskInstance.ListenerBeforeExecuteDependentTask(sender);
			}
		}

		
		private System.Collections.ArrayList _executedTask = new ArrayList();
		
		/// <summary>
		/// Se creo para separar el codigo del ListenerAfterExecuteDependentTask
		/// de esta manera, se puede llamar solamente a esta porcion de codigo, despues de un warning
		/// sin necesidad de hacer todo otra vez; nos evitamos volver a revisar los errores y los warnings
		/// ya que si alguna vez se mostro el warning, se hizo en forma modal y se continuo en el worflow, por lo
		/// cual no se pudieron generar errores nuevos.
		/// </summary>
		/// <param name="task"></param>
		/// <param name="sender"></param>
		private void ejecutar (ITask task, object sender)
		{
			ITask mainTask = (ITask) _process.MainTask.TaskInstance;
			mainTask.ListenerAfterExecuteDependentTask(sender);
			foreach(TaskDynamicInfo secondaryTaskInfo in _process.SecondaryTasks)
			{
				ITask secondaryTaskInstance = (ITask)secondaryTaskInfo.TaskInstance;
				secondaryTaskInstance.ListenerAfterExecuteDependentTask(sender);
			}
			_executedTask.Add( sender );
            //Cristian Tarea 0000051 20110411
            Sistema.AddValueFilter(Process.ProcessName, Process.MainTask.KeyTask, "FechaDesde", "222");
            //Fin Cristian

			bool estado = this.Step();
			if (estado)
			{
				ITask nextTask = this.NextTask();
				if(nextTask!= null)
				{    
					this._state = ProcessState.State.NextState;
					
					if(OnNextTask != null)
						OnNextTask(nextTask.GetTaskName());
				}
				else 
				{
					if(OnEndProcess != null)
						OnEndProcess(task.GetTaskName());
				}
			}
			else
			{
				if(OnErrorFlushProcess != null)
					OnErrorFlushProcess (task.GetTaskName(), _errorMessage, _flushErrors);
			}
				

			/*ITask nextTask = this.NextTask();
			if(nextTask!= null)
			{    
				this._state = ProcessState.State.NextState;
				if(OnNextTask != null)
					OnNextTask(nextTask.GetTaskName());
			}
			else 
			{
				if(OnEndProcess != null)
					OnEndProcess(task.GetTaskName());
			}*/
		}


		/// <summary>
		/// se ejecutara cuando una tarea se ejecute completamente
		/// </summary>
		/// 

		public void Continue()
		{
			//this.MostroWarnings = true; 
		}
		void ListenerAfterExecuteDependentTask(object sender, System.EventArgs e)
		{//ST			
			ITask task = (ITask)sender;
			if(task.GetErrors().Count == 0) //no hay errores
			{	
				string _str = task.GetWarnings();
				if ((_str == null || _str.Equals(String.Empty)) || this.MostroWarnings )//no hay warnings
				{			
					ejecutar(task, sender);
                    Console.WriteLine("Levantar variables ...");
					this.MostroWarnings = false;
				}
				else 
				{
					if (!this.MostroWarnings)  //hay warnings
					{    
						//muestro la ventana del warning
						this.MostroWarnings = true;	
						if(OnProcessWarnings != null)
							OnProcessWarnings(task.GetTaskName());
					}
				}
			}
			else //hay errores
			{
					//muestro la ventana de errores
					if(OnProcessErrors != null)
						OnProcessErrors(task.GetTaskName());
			}
			
		}


		private string Clear()
		{
			return null;	
		}

		private bool Step()
		{
			//SetMessage( "Ejecutada tarea "+Convert.ToString(this._executedTask.Count)+"/"+Convert.ToString( this._tasks)+ " " );
			//SetProgress( this._executedTask.Count ) ;
			bool ok = true;
			if (CanFlush())
			{
				this.Commit();
				_processFlushed= this.Flush();				
				if (_processFlushed)
				{
					this.NotifyEndFlushProcess();
					SetMessage("El proceso se ha almacenado con exito");
				}
				else
				{	
					SetMessage("Existieron problemas al intentar finalizar el proceso");
					ok = false;
				}
				ok = IsValidFlush() && ok ;				
			}
			return ok;
		}

		private bool IsValidFlush()
		{			
			bool ok = true;
			_flushErrors.Clear();
			ArrayList tasks = this.SortedTasks(TaskStaticInfo.SortOrder.OrderDA);
			foreach (TaskDynamicInfo task in tasks)
			{
				if(task.TaskInstance is IValidateAfterFlush)
				{
					IValidateAfterFlush taskDependent = (IValidateAfterFlush) task.TaskInstance;
					if(!taskDependent.IsValidFlush(tasks))
					{
						ok = false;
						ItemsDatasetErrors e = taskDependent.GetFlushErrors();
						_flushErrors.AddAll(e);						
						SendMail(taskDependent.GetExceptionContent().ToString());			
						FlushException(taskDependent.GetExceptionContent().ToString());
						

					}
					
				}
			}
			
			
			return ok;
		}

        //German 20101130 - Tarea 927
		private void SendMail(string Message)		
		{

            bool HttpMailActivo = Variables.GetValueBool("Debug.HTTPMail.Habilitado"); ;
            if (true) //Por compatibilidad con lo anterior que se hacia siempre!
            {
                security.dll.Mail.SMTPClient objMail = new mz.erp.security.dll.Mail.SMTPClient();
                security.dll.Mail.SMTPMailMessage objMailMessage = new mz.erp.security.dll.Mail.SMTPMailMessage();

                string Destino = "";
                Destino = Variables.GetValueString("Momentos." + _process.ProcessName + ".Mail.To");
                if (Destino == "")
                {
                    Destino = Variables.GetValueString("Debug.ManejadorDeExcepciones.Mail.To");
                }
                objMailMessage.To = Destino;
                objMailMessage.Subject = "Comprobante NO Grabado";
                objMailMessage.Body = Message;
                try
                {
                    objMail.Server = mz.erp.businessrules.Variables.GetValueString("Debug.Mail.Server");
                    objMail.Port = Convert.ToInt32(mz.erp.businessrules.Variables.GetValueString("Debug.Mail.Port"));
                    objMail.SendMail(objMailMessage);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }


            }
            if (HttpMailActivo)//Para poder mandar mail desde un webmail via HTTP
            {
                string username = mz.erp.businessrules.Variables.GetValueString("Debug.HTTPMail.UserName");//"mzprueba@gmail.com";
                string mailAddress = mz.erp.businessrules.Variables.GetValueString("Debug.HTTPMail.MailAddress");//"mzprueba@gmail.com";
                string mailAddressDisplay = mz.erp.businessrules.Variables.GetValueString("Debug.HTTPMail.MailAddressDisplay");//"Equipo Desarrollo";
                string password = mz.erp.businessrules.Variables.GetValueString("Debug.HTTPMail.Password");//"mzprueba2010";
                string subject = mz.erp.businessrules.Variables.GetValueString("Debug.HTTPMail.Subject");//"Comprobante NO Grabado";
                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                SmtpServer.Port = Convert.ToInt32(mz.erp.businessrules.Variables.GetValueString("Debug.HTTPMail.Port"));//25;
                SmtpServer.Host = mz.erp.businessrules.Variables.GetValueString("Debug.HTTPMail.Server");//"smtp.gmail.com";
                SmtpServer.EnableSsl = true;
                MailMessage mail = new MailMessage();
                mail = new MailMessage();
                try
                {
                    mail.From = new MailAddress(mailAddress, mailAddressDisplay, System.Text.Encoding.UTF8);
                    string Destino = Variables.GetValueString("Momentos." + _process.ProcessName + ".HTTPMail.To");
                    if (Destino == "")
                    {
                        Destino = Variables.GetValueString("Debug.HTTPMail.To");
                    }

                    ArrayList dests = mz.erp.systemframework.Util.Parse(Destino, ";");
                    foreach (string dest in dests)
                    {
                        mail.To.Add(dest);
                    }
                    mail.Subject = subject;
                    mail.Body = Message;
                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            
		}
        //Fin German 20101130 - Tarea 927

		private void FlushException(string Message)
		{
			string maquina = Environment.MachineName;
			string usuario = Security.IdUsuario;
			string version = Environment.Version.ToString();
			string excSource = "FlushError";
			string excType = "FlushError";
			string excMensaje = Message;
			string excTargetSite = "ProcessManager";
			string excStackTrace = "";
			string excInnerException = "";
			string excHelpLink = "";
			string exception = Message;
			string appDomain = "ProcessManager";
			string codebase = "ProcessManager";
			mz.erp.businessrules.sy_Excepciones.AddExcepcion(
				maquina, 
				usuario, 
				version, 
				excSource, 
				excType, 
				excMensaje, 
				excTargetSite, 
				excStackTrace, 
				excInnerException, 
				excHelpLink, 
				exception, 
				appDomain, 
				codebase);
		}

		ItemsDatasetErrors _flushErrors = new ItemsDatasetErrors();


		
		private void NotifyEndFlushProcess()
		{
			ArrayList tasks = this.SortedTasks(TaskStaticInfo.SortOrder.OrderDA);
			foreach (TaskDynamicInfo task in tasks)
			{
				if(task.TaskInstance is IDependentPersistentTask)
				{
					IDependentPersistentTask taskDependent = (IDependentPersistentTask) task.TaskInstance;

					foreach(TaskDynamicInfo tasksFlushed in tasks)
					{
						taskDependent.ListenerAfterFlush(tasksFlushed.TaskInstance);
					}
				}
			}
			
		}

		private ITask NextTask()
		{
			ArrayList _tasksOrdered = this.SortedTasks(TaskStaticInfo.SortOrder.OrderBR);
			_actualTaskIndex++;
			if(_actualTaskIndex < _tasksOrdered.Count)
			{				
				ITask task = (ITask)((TaskDynamicInfo)_tasksOrdered[_actualTaskIndex]).TaskInstance;		
				return task;
			}
			else return null;

		}

		private ITask PreviousTask()
		{
			ArrayList _tasksOrdered = this.SortedTasks(TaskStaticInfo.SortOrder.OrderBR);
			if(_actualTaskIndex > 0)
			{
				_actualTaskIndex--;
				return (ITask)((TaskDynamicInfo)_tasksOrdered[_actualTaskIndex]).TaskInstance;
			}
			else return null;

		}

		private bool CanFlush()
		{
			bool result = true;
			if(! _processFlushed)
			{
				int i=0;
				while ((i<(_tasksBeforeFlush.Count)) && (result))
				{
					if (!(_executedTask.Contains( _tasksBeforeFlush[i])))
					{
						result = false;
					}
					i++;
				}
				return result;
			}
			else return false;
		}

		private void SetProgress(long value)
		{
			this._processProgress = Convert.ToInt32(Math.Round(Convert.ToDecimal(value),0));
			if (this.OnProgressCounterChanged != null)
				OnProgressCounterChanged( null, new System.EventArgs() );
		}
		private void SetMessage(string message)
		{
			this._message = message;
			if (this.OnProcessMessageChanged != null)
				OnProcessMessageChanged( null, new System.EventArgs() );
		}
		private void Init()
		{
			DateTime fecha = DateTime.Now;
			_processProgressTop = 100;
			AddMainTask();
			AddSecondaryTask();
			SetMessage("Inicializando...");
			TimeSpan  diff = DateTime.Now.Subtract(fecha);
			Console.WriteLine("Antes del CallClassInit " + diff.TotalSeconds + " " + DateTime.Now);
			CallClassInit();
			diff = DateTime.Now.Subtract(fecha);
			Console.WriteLine("Despues de  CallClassInit " + diff.TotalSeconds + " " + DateTime.Now);
			SetProgress(90);
			SetTasksBeforeFlush();
			InitEvents();
			SetProgress(100);
			SetMessage("Fin Carga Proceso...");
			SetProgress(0);
			_processProgressTop = this.SortedTasks( TaskStaticInfo.SortOrder.OrderUI ).Count+1;
			_tasks = _processProgressTop;
			
			
		}
		#endregion

		#region Metodos Publicos
		private System.Collections.ArrayList _tasksBeforeFlush = new ArrayList();

		public bool AllowShow(string keyTask)
		{
			ArrayList _tasksOrdered = this.SortedTasks(TaskStaticInfo.SortOrder.OrderBR);
			foreach(TaskDynamicInfo task in _tasksOrdered)
			{
				if(task.KeyTask.Equals(keyTask))
					return task.OrderUI > 0;
			}
			return false;
		}
		
		public bool IsFirstTask(string keyTask)
		{
			ArrayList _tasksOrdered = this.SortedTasks(TaskStaticInfo.SortOrder.OrderBR);
			TaskDynamicInfo taskInfo = (TaskDynamicInfo)_tasksOrdered[0];
			return taskInfo.KeyTask.Equals(keyTask);

		}

		public bool IsLastTask(string keyTask)
		{
			ArrayList _tasksOrdered = this.SortedTasks(TaskStaticInfo.SortOrder.OrderBR);
			TaskDynamicInfo taskInfo = (TaskDynamicInfo)_tasksOrdered[_tasksOrdered.Count - 1];
			return taskInfo.KeyTask.Equals(keyTask);

		}

		public bool IsBackState()
		{
			return this._state.Equals(ProcessState.State.BackState);
		}
		
		public bool IsNextState()
		{
			return this._state.Equals(ProcessState.State.NextState);
		}

		public bool IsFlushed()
		{
			return this._processFlushed;
		}

		private void SetTasksBeforeFlush()
		{			
			if (_process.MainTask.TaskInstance is ITaskBeforeFlush)//  || _process.MainTask.TaskInstance is IPersistentTask)
			{
				_tasksBeforeFlush.Add( _process.MainTask.TaskInstance );
			}
			foreach(TaskDynamicInfo secondaryTaskInfo in _process.SecondaryTasks)
			{
				object secondaryTaskInstance = secondaryTaskInfo.TaskInstance;
				if (secondaryTaskInstance is ITaskBeforeFlush)
				{
					_tasksBeforeFlush.Add( secondaryTaskInstance );
				}
				
			}				
		}
		public ArrayList SortedTasks()
		{
			ArrayList _sortedTaskForInputData = SortTasks(TaskStaticInfo.SortOrder.Default);
			return _sortedTaskForInputData;
		}
		public ArrayList SortedTasks(TaskStaticInfo.SortOrder sortOrder)
		{
			ArrayList _sortedTaskForInputData = SortTasks(sortOrder);
			return _sortedTaskForInputData;
		}


		public void Commit()
		{
			ArrayList sortedTask = SortTasks(TaskStaticInfo.SortOrder.OrderDA);
			ProcessCollectionData processCollectionData = new ProcessCollectionData();
			foreach(TaskDynamicInfo taskInfo in sortedTask)
			{
				if(taskInfo.TaskInstance is IPersistentTask)
				{
					IPersistentTask taskInstance = (IPersistentTask)taskInfo.TaskInstance;
					taskInstance.PutExtraDataOnCommit( processCollectionData );
					taskInstance.Commit();
					processCollectionData.Add( taskInstance.GetData() );

				}
			}
		}

		public void EndByUser()
		{			
			ArrayList sortedTask = SortTasks(TaskStaticInfo.SortOrder.OrderDA);
			//ProcessCollectionData processCollectionData = new ProcessCollectionData();
			foreach(TaskDynamicInfo taskInfo in sortedTask)
			{
				if(taskInfo.TaskInstance is ITask)
				{
					ITask taskInstance = (ITask)taskInfo.TaskInstance;
					taskInstance.FormHasClosed();
				}
			}
		}

		/// <summary>
		/// Ordena las tareas segun lo definido para en el modelo de datos 
		/// Inicia una transacción para toda la grabación del proceso
		/// Genero la sentencia de replicacion para todo el proceso
		/// Armo una coleccion para ir almacenando los datos del proceso mientras se va guardando
		/// Guardo informacion acerca del proceso por si alguna tarea debe realizar una lógica distinta
		/// Itero segun el orden de grabación definido para el proceso
		/// Ofrezco a la tarea antes de almacenarse los datos del proceso que se han ido guardando
		/// Guardo el dataset
		/// Agrego a la coleccion de datos almacenados del proceso
		/// Cierra la transaccion o realiza el roolback
		/// </summary>
		public bool Flush()
		{
			bool state = false;
			//Ordena las tareas
			ArrayList sortedTask = SortTasks(TaskStaticInfo.SortOrder.OrderDA);
			//mz.erp.commontypes.SentenciasReplicacion _replication = null;

			//Inicia una transaccion
			string IdTransaction = dataaccess.PoolTransaction.BeginTransaction();

			//German 2009108
			ProcessCollectionData _processCollectionData = new ProcessCollectionData();
			//Fin German 2009108

			try
			{
				//Genero la sentencia de replicacion para todo el proceso
				mz.erp.commontypes.SentenciasReplicacion _sentences = new SentenciasReplicacion();
				mz.erp.commontypes.SentenciasReplicacion _mainsentence = new SentenciasReplicacion();

				//Armo una coleccion para ir almacenando los datos del proceso mientras se va guardando
				
				//German 2009108
				//ProcessCollectionData _processCollectionData = new ProcessCollectionData();
				//Fin German 2009108
		
				//Guardo informacion acerca del proceso por si alguna tarea debe realizar una lógica distinta
				_processCollectionData.ProcessId = this._process.IdProcess;

				//Itero segun el orden de grabación definido para el proceso
				foreach( TaskDynamicInfo taskInfo in sortedTask)
				{
					if (taskInfo.TaskInstance is IPersistentTask )
					{
						IPersistentTask _taskInstance = (IPersistentTask)taskInfo.TaskInstance;
						//Ofrezco a la tarea antes de almacenarse los datos del proceso que se han ido guardando
						_taskInstance.PutExtraData( _processCollectionData );

						//Guardo el dataset
						_taskInstance.Flush( IdTransaction );
						//_taskInstance.Flush( IdTransaction );
				
						if (taskInfo.Order == 1) //Tarea Principal
						{
							_mainsentence = _taskInstance.GetSentenceReplication();
						}
						else
						{
							SentenciasReplicacion replication = _taskInstance.GetSentenceReplication();
							if(replication != null)
							{
								System.Text.StringBuilder _sentencia = replication.Sentence;
								if (_sentencia != null)
								{
									_sentences.Sentence.Append( _sentencia );
								}
							}
						}
						//Agrego a la coleccion de datos almacenados del proceso
						_processCollectionData.Add( _taskInstance.GetData() );
					}
				}
                //throw new Exception("Excepcion explicita para probar Tarea del SP 15");
				//Almaceno el conjunto de sentencias de replicacion
                //German 20110301 - Tarea 0000079
                /*
				if (_mainsentence != null &&  _mainsentence.IdTipoDeSentencia != null)
				{
					_mainsentence.Sentence.Append ( _sentences.Sentence );
					_mainsentence.Update();
					mz.erp.businessrules.transactionmanager.SentenciasReplicacion.Flush(IdTransaction, _mainsentence);
				}
                */
                //Fin German 20110301 - Tarea 0000079

               
				//Almaceno datos
				dataaccess.PoolTransaction.Commit(IdTransaction);
				state = true;
			}
			catch(Exception e)
			{
				System.Console.WriteLine(e.ToString());
				dataaccess.PoolTransaction.RollBack(IdTransaction);
				state = false;
				_errorMessage = e.Message;
			}
			comprobantes.GuardarSaldoCuentaCorriente.GetInstance().ClearDataSet(this._process);
			return state;
		}

		private int _actualTaskIndex = -1;
		public void StartProcess()
		{
			
			/*Primero Verificamos si Hay Validacioes q hacer antes de Iniciar el proceso*/
			bool IsValid = true;
			if(this._process.CheckValidOnStart)
			{
				ArrayList sortedTask = SortTasks(TaskStaticInfo.SortOrder.OrderBR);
				foreach( TaskDynamicInfo taskInfo in sortedTask)
				{
					ITask _taskInstance = (ITask)taskInfo.TaskInstance;
					IsValid = IsValid && _taskInstance.IsValidForStartProcess();
				}
			}
			if(IsValid)
			{
				_actualTaskIndex = -1;
				ITask firstTask = (ITask) this.NextTask();
				this._state = ProcessState.State.NextState;
				if(OnNextTask != null)
					OnNextTask(firstTask.GetTaskName());
			}
			else
			{
				ArrayList sortedTask = SortTasks(TaskStaticInfo.SortOrder.OrderBR);
				ItemsDatasetErrors errors = new ItemsDatasetErrors();
				foreach( TaskDynamicInfo taskInfo in sortedTask)
				{
					ITask _taskInstance = (ITask)taskInfo.TaskInstance;
					errors.AddAll(_taskInstance.GetErrors());
					
				}
				if(OnProcessErrorsOnStart != null)
					OnProcessErrorsOnStart(errors);
			}
		}
		#endregion

		
	}

	public class ProcessState
	{
		public enum State
		{
			StartState,
			NextState,
			BackState,
			SuspendState,
			FinishedState,
			FlushingState
		}
	}
}
