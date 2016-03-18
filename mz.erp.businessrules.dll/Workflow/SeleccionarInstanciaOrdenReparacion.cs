using System;
using System.Collections;
using System.Data;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de SeleccionarInstanciaOrdenReparacion.
	/// </summary>
	public class SeleccionarInstanciaOrdenReparacion : ITask
	{
		public SeleccionarInstanciaOrdenReparacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas

		private ProcessManager _processManager;
		private string _taskName;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
        private long _idOrdenReparacion = 0;
		private InstanciasOrdenReparacion _instancias = new InstanciasOrdenReparacion();
		private object _selectedItem; 
		private RepuestosOrdenreparacion _repuestos = new RepuestosOrdenreparacion();		

		#endregion

		#region Variables Publicas

		public RepuestosOrdenreparacion Repuestos
		{
			get{return _repuestos;}
		}
			
		public InstanciasOrdenReparacion InstanciasOrdenReparacion
		{
			get{return _instancias;}
		}

		public object SelectedItem
		{
			set
			{
				if(_selectedItem != value)
				{
					_selectedItem = value;
					GetRepuestos();

				}
			}
		}

		public long IdInstanciaOrdenReparacion
		{
			get{return ((InstanciaOrdenReparacion)_selectedItem).IdInstanciaOrdenReparacion;}
		}

		public long IdOrdenReparacion
		{
			get{return _idOrdenReparacion;}
		}

			
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
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionReparacionAjustes)))
			{
				SeleccionReparacionAjustes sra = (SeleccionReparacionAjustes)sender;
				LoadFromSeleccionReparacionAjustes(sra);
				
			}
		}

		private void LoadFromSeleccionReparacionAjustes(SeleccionReparacionAjustes sra)
		{
			_idOrdenReparacion = Convert.ToInt64(sra.IdOrdenReparacion);
			_instancias.Clear();
			_instancias.IdOrdenReparacion = _idOrdenReparacion;
			_repuestos.IdOrdenReparacion = _idOrdenReparacion;
			_repuestos.Clear();
			DataSet data = mz.erp.businessrules.st_InstanciaOrdenReparacion.GetList(Convert.ToInt64(_idOrdenReparacion));
			foreach(DataRow row in data.Tables[0].Rows)
			{
				InstanciaOrdenReparacion ins = new InstanciaOrdenReparacion();
				ins.IdInstanciaOrdenReparacion = Convert.ToInt64(row["IdInstanciaOrdenReparacion"]);
				ins.IdTecnico = Convert.ToInt64(row["IdTecnico"]);
				ins.Tecnico = Convert.ToString(row["NombreTecnico"]);
				_instancias.Add(ins);
			}
			if(_instancias.Count == 1)
			{
				_selectedItem = _instancias.Get(0);
				GetRepuestos();
			
			}

		}

		private void GetRepuestos()
		{
			InstanciaOrdenReparacion ins = (InstanciaOrdenReparacion)_selectedItem;
			_repuestos.Clear();
			_repuestos.IdInstanciaOrdenReparacion = ins.IdInstanciaOrdenReparacion;
			DataSet dataRepuestos = mz.erp.businessrules.st_RepuestoOrdenReparacion.GetList(long.MinValue,_repuestos.IdInstanciaOrdenReparacion, null);
			foreach(DataRow row in dataRepuestos.Tables[0].Rows)
			{
				Repuesto rep = new Repuesto();
				rep.IdProducto = Convert.ToString(row["IdProducto"]);
				rep.CantidadEntregada = Convert.ToDecimal(row["Entregado"]);
				rep.CantidadPedida = Convert.ToDecimal(row["Cantidad"]);
				rep.CantidadReservada = Convert.ToDecimal(row["Reservado"]);
				if (rep.IdProducto != String.Empty) 
				{
					_repuestos.Add(rep);
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
			return _instancias.Count > 1;
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
			// TODO: agregar la implementación SeleccionarInstanciaOrdenReparacion.GetWarnings
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

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			this.AllowPrevious();
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

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}
	}


	public sealed class InstanciasOrdenReparacion:CollectionBase
	{
		private long _idOrdenReparacion;

		public long IdOrdenReparacion
		{
			get{return _idOrdenReparacion;}
			set{_idOrdenReparacion = value;}
		}

		public void Clear()
		{
			this.List.Clear();
		}

		public void Add(InstanciaOrdenReparacion ins)
		{
			this.List.Add(ins);
		}

		public InstanciaOrdenReparacion Get(int index)
		{
			return (InstanciaOrdenReparacion)this.List[index];
		}
	}

	public sealed class InstanciaOrdenReparacion
	{
		private long _idInstanciaOrdenReparacion = 0;
		private string _tecnico = string.Empty;
		private long _idTecnico = 0;

		public string Tecnico
		{
			get{return _tecnico;}
			set{_tecnico = value;}
		}


		public long IdTecnico
		{
			get{return _idTecnico;}
			set{_idTecnico = value;}
		}

		public long IdInstanciaOrdenReparacion
		{
			get{return _idInstanciaOrdenReparacion;}
			set{_idInstanciaOrdenReparacion = value;}
		}

	
	
	}

	public sealed class RepuestosOrdenreparacion : CollectionBase
	{
		private long _idOrdenReparacion = 0;
		private long _idInstanciaOrdenReparacion = 0;
		private bool _merge = true;

		public RepuestosOrdenreparacion(bool Merge)
		{
			_merge = Merge;
		}

		public RepuestosOrdenreparacion()
		{
			
		}

		public long IdOrdenReparacion
		{
			get{return _idOrdenReparacion;}
			set{_idOrdenReparacion = value;}
		}

		public long IdInstanciaOrdenReparacion
		{
			get{return _idInstanciaOrdenReparacion;}
			set{_idInstanciaOrdenReparacion = value;}
		}

		public void Remove(Repuesto rep)
		{
			this.List.Remove(rep);
		}

		public void Add(Repuesto rep)
		{
			
			if(_merge)
			{
				Repuesto r = this.Get(rep.IdProducto);
				if(r == null)
					this.List.Add(rep);
				else
				{
					r.CantidadEntregada += rep.CantidadEntregada;
					r.CantidadPedida += rep.CantidadPedida;
					r.CantidadReservada+=rep.CantidadReservada;
				}
			}
			else
			{
				this.List.Add(rep);
			}
		}

		private Repuesto Get(string IdProducto)
		{
			foreach(Repuesto rep in this.List)
			{
				if(rep.IdProducto.Equals(IdProducto))
					return rep;

			}
			return null;
		}


		public void Clear()
		{
			this.List.Clear();
		}

	}

	public sealed class Repuesto
	{
		private string _idProducto = string.Empty;
		private decimal _cantidad = 0;
		private decimal _cantidadReservada = 0;
		private decimal _entregado = 0;
		private long _idRepuestoOrdenReparacion = 0;

		public Repuesto(){}
			
		public long IdRepuestoOrdenReparacion
		{
			get{return _idRepuestoOrdenReparacion;}
			set{_idRepuestoOrdenReparacion = value;}
		}

		public decimal CantidadReservada
		{
			get{return _cantidadReservada;}
			set{_cantidadReservada = value;}
		}

		public string IdProducto
		{
			get{return _idProducto;}
			set{_idProducto = value;}
		}

		public decimal CantidadPedida
		{
			get{return _cantidad;}
			set{_cantidad = value;}
		}

		public decimal CantidadEntregada
		{
			get{return _entregado;}
			set{_entregado = value;}

		}

	}
}
