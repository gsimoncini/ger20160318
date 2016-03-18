using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ImprimirReporteDeComprobante.
	/// </summary>
	public abstract class ImprimirReporteDeComprobante : ITask
	{
		public ImprimirReporteDeComprobante()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		#region Variables Privadas
			
			private ProcessManager _processManager;
			private string _taskName;
			private ItemsDatasetErrors _errores = new ItemsDatasetErrors(); 
			private ReportParameterCollection _parametros = new ReportParameterCollection();
			private DataTable _dataSource;
			private string _idComprobante = string.Empty;
			private string _idTipoDeComprobante;
			private string _familiaDeComprobantes;
			

		#endregion

		#region Propiedades

		protected string IdComprobante
		{
			set
			{
				_idComprobante = value;
				
			}
		}
			
		public ReportParameterCollection Parametros
		{
			get
			{
				return _parametros;
			}
		}

		public string FamiliaDeComprobantes
		{
			get
			{
				return _familiaDeComprobantes;
			}
		}

		public DataTable DataSource
		{	
			get
			{		
				//_familiaDeComprobantes = ObtenerFamilia();
				return GenerateDataSource(_idComprobante, _familiaDeComprobantes);
			}
		}

		public string IdTipoDeComprobante
		{
			get
			{
				return _idTipoDeComprobante;
			}
			set
			{
				if(value != _idTipoDeComprobante)
				{
					_idTipoDeComprobante = value;
					_familiaDeComprobantes =  this.ObtenerFamilia();				
					
				}
			}
		}
			
		private bool _impresionFiscalExitosa = false;
		public bool ImpresionFiscalExitosa
		{
			get {return _impresionFiscalExitosa;}			
			set {_impresionFiscalExitosa = value;}
		}
		private bool _soportaComprobanteFiscal = false;
		public bool SoportaComprobanteFiscal 
		{
			get {return _soportaComprobanteFiscal;}			
			set {_soportaComprobanteFiscal = value;}
		}

		#endregion

		#region Metodos protegidos

		protected void AddVariablesAuxiliares(ArrayList varAuxs)
		{
			//Arreglar
			
			foreach(VariableAuxiliar var in varAuxs)
			{
				
					string valor = var.Descripcion +": " +var.Valor;
					_parametros.Add(new ReportParameter("Param" + var.Id, valor));
				
			}
		}

		protected DataTable GenerateDataSource(string IdComprobante, string family)
		{
			return mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForComprobantesReport(IdComprobante, family);
		}

		#endregion

		#region Metodos privados
		
		private string ObtenerFamilia()
		{
			/*
			sy_VariablesDataset  data = mz.erp.businessrules.sy_Variables.GetList("Comprobantes.TiposDeComprobantes.");
			System.Data.DataTable table = data.Tables[0];
			
			foreach(System.Data.DataRow row in table.Rows)
			{
				ArrayList ar = mz.erp.systemframework.Util.Parse((string)row["ValorDefault"],",");
				if (ar.Contains(_idTipoDeComprobante))
				{
					string [] partes = ((string)row["IdVariable"]).Split('.');
					family  = partes[partes.Length-1];
				}
			}
			*/
			string family = string.Empty;
			if(_idTipoDeComprobante != null && _idTipoDeComprobante != string.Empty)
			{
				DataRow rowTipoComp = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(_idTipoDeComprobante);
				if(rowTipoComp != null)
				{
					family = Convert.ToString(rowTipoComp["Familia"]);
				}
			}
			return family;

		}
		
		#endregion



		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
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
			// TODO: agregar la implementación ImprimirReporteDeComprobante.ListenerTaskDependentChanged
		}

		public virtual void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación ImprimirReporteDeComprobante.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			_errores = new ItemsDatasetErrors();
			_parametros = new ReportParameterCollection();
			_parametros.Add(new ReportParameter("DireccionEmpresa", Variables.GetValueString("Sistema.DireccionEmpresa")));
			_parametros.Add(new ReportParameter("CategoriaIvaEmpresa",Variables.GetValueString("Sistema.CategoriaDeIvaEmpresa")));
			_parametros.Add(new ReportParameter("TelefonoEmpresa",	Variables.GetValueString("Sistema.TelefonosEmpresa")));
			_parametros.Add(new ReportParameter("CUITEmpresa",Variables.GetValueString("Sistema.CUITEmpresa")));
			_parametros.Add(new ReportParameter("IngresosBrutosEmpresa",Variables.GetValueString("Sistema.IngresosBrutosEmpresa")));
			_parametros.Add(new ReportParameter("InicioActividadesEmpresa",Variables.GetValueString("Sistema.InicioActividadesEmpresa")));
			_parametros.Add(new ReportParameter("Logo",Variables.GetValueString("Reportes.Logo")));
			_parametros.Add(new ReportParameter("Etiqueta1",Variables.GetValueString("Cuentas.CampoAuxiliar1.Etiqueta")));
			_parametros.Add(new ReportParameter("Etiqueta2",Variables.GetValueString("Cuentas.CampoAuxiliar2.Etiqueta")));
			_parametros.Add(new ReportParameter("Etiqueta3",Variables.GetValueString("Cuentas.CampoAuxiliar3.Etiqueta")));
					
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
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
			
			return _errores;
		}
		public string GetWarnings()
		{			
			return null;
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processManager = processManager;
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
	}
}
