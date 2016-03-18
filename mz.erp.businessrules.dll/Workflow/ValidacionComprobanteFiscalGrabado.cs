using System;
using mz.erp.businessrules.comprobantes;
using System.Text;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules	
{
	/// <summary>
	/// Descripción breve de ValidacionComprobanteFiscalGrabado.
	/// </summary>
	public class ValidacionComprobanteFiscalGrabado: ITask, IValidateAfterFlush	
	{
		public ValidacionComprobanteFiscalGrabado()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas ITask

		protected string _taskName = string.Empty;		
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ItemsDatasetErrors _flushErrors = new ItemsDatasetErrors();
		protected ProcessManager _processParent;

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
			return true;
		}

		public bool IsValid()
		{
			_errores.Clear();
			return true;
		}

		public bool AllowShow() 
		{
			return false;
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

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}
		#endregion

		#region Miembros de IValidateAfterFlush

		public ItemsDatasetErrors GetFlushErrors()
		{
			return _flushErrors;			
		}


		public StringBuilder GetMailContent()
		{
			return _mailContent;
		}

		public StringBuilder GetExceptionContent()
		{
			return _mailContent;
		}

		StringBuilder _mailContent = new StringBuilder();
		StringBuilder _exceptionContent = new StringBuilder();

		public bool IsValidFlush(ArrayList Tasks)
		{
			bool ok = true;
			bool activo = Variables.GetValueBool("Fiscal.Activo");	
			if (activo)
			{
				foreach (TaskDynamicInfo task in Tasks)
				{
					object instance = task.TaskInstance;
					if(instance.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta)))
					{
						ComprobanteDeVenta comp = (ComprobanteDeVenta) instance;
						string Numero = comp.Numero;
						string IdTipoDeComprobante = comp.TipoComprobanteDestino;
						decimal Total = comp.Total;
						ok = mz.erp.businessrules.tsa_Comprobantes.ExistsNumeration(Numero, IdTipoDeComprobante);
						if(!ok)
						{
							ItemDatasetError error = new ItemDatasetError("Comprobante","El Comprobante NO se ha Grabado","El comprobante " + IdTipoDeComprobante + " Nº " + Numero + " No se ha Grabado. Se ha enviado un Mail a sus Supervisores. Tendrá un Sobrante de $" + Total);
							_flushErrors.Add( error );
							Build_Content(comp);						
						}
					}
				}
			}
			return ok;
		}
		
		private void Build_Content(ComprobanteDeVenta comp)
		{
			_mailContent.Append("El siguiente comprobante no se ha guardado:");
			_mailContent.Append(Environment.NewLine);
			_mailContent.Append("Tipo de Comprobante: ");
			_mailContent.Append(comp.TipoComprobanteDestino);
            //German 20101215 - Tarea 993
            _mailContent.Append(Environment.NewLine);
            _mailContent.Append("Número: ");
            _mailContent.Append(comp.Numero);
            //Fin German 20101215 - Tarea 993
			_mailContent.Append(Environment.NewLine);
            _mailContent.Append("Responsable logueado: ");
			_mailContent.Append(Security.IdUsuario);
			_mailContent.Append(Environment.NewLine);
			_mailContent.Append("Responsable: ");
			DataRow row = mz.erp.businessrules.tsh_Personas.GetByPk(comp.IdResponsable);
			if(row != null)
				_mailContent.Append(Convert.ToString(row["Nombre"]));
			_mailContent.Append(Environment.NewLine);
			_mailContent.Append("Fecha: ");
			_mailContent.Append(comp.FechaComprobante);
			_mailContent.Append(Environment.NewLine);
			_mailContent.Append("Total: ");
			_mailContent.Append(comp.Total);
			_mailContent.Append(Environment.NewLine);
			_mailContent.Append("Cliente: ");
			_mailContent.Append(comp.Cuenta.Codigo);
			_mailContent.Append(" ");
			_mailContent.Append(comp.Cuenta.Nombre);
			
		}

		#endregion
	}
}
