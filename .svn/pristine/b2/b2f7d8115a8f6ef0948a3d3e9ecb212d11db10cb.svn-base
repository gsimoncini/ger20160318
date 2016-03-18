using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
    public class ConsultarSeguimientoAcopio : ITask    
    {



        private string _idCuenta = string.Empty;
        private string _codigoCuenta = String.Empty;
        private DateTime _fechaDesde = DateTime.Now.AddDays(-30);
        private DateTime _fechaHasta = DateTime.Now;
        private DataTable _result = new DataTable();
        private DataTable _resultDetalleAcopio = new DataTable();	

        public DateTime FechaDesde
        {
            get { return _fechaDesde; }
            set { _fechaDesde = value; }
        }

        public DateTime FechaHasta
        {
            get { return _fechaHasta; }
            set { _fechaHasta = value; }
        }
        public string CodigoCuenta
        {
            get { return _codigoCuenta; }
            set
            {
                
                if (_codigoCuenta != value)
                {
                    _codigoCuenta = value;
                    _idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);
                }
                
            }
        }

        public DataTable Result
        {
            get { return _result; }
        }

        public DataTable ResultDetalleAcopio
        {
            get { return _resultDetalleAcopio; }
        }
        
        #region Variables Privadas ITask

		protected string _taskName = string.Empty;		
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;

		#endregion


		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public virtual void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public virtual void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public virtual void Init()
		{
			
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			return true;
		}

		public virtual bool IsValid()
		{
			_errores.Clear();
			return true;
		}

		public virtual bool AllowShow() 
		{
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
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

		public bool AllowPrevious()
		{
			return true;
		}

		public virtual void Previous()
		{
			
		}

		public virtual void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion



        public void RefreshData()
        {


            _result = mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetAcopios(_idCuenta, this.FechaDesde, this.FechaHasta).Tables[0];
        }

        public void RefreshDataDetalleAcopio(string IdComprobante)
        {

            _resultDetalleAcopio = mz.erp.businessrules.reportes.tsa_ReporteComprobantesDeVenta.GetDetalleAcopio(IdComprobante).Tables[0];
        }




    }

}
