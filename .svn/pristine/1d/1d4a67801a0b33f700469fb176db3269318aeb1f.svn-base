using System;
using System.Collections;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de CapturarDatosPreviosComprobantes.
	/// </summary>
	public class CapturarDatosPreviosComprobantes: ITask
	{
		public class ComprobantesConDatosPrevios: CollectionBase, IEnumerator
		{
			public class ComprobanteConDatosPrevios
			{
				public ComprobanteConDatosPrevios( string idComprobante, string idTipoDeComprobante)
				{
					this._idComprobante = idComprobante;
					this._idTipoDeComprobante = idTipoDeComprobante;
				}
				private string _idComprobante = string.Empty;
				private string _idTipoDeComprobante = string.Empty;
				public string IdComprobante 
				{
					get { return _idComprobante ; }
				}
				public string IdTipoDeComprobante
				{
					get {return _idTipoDeComprobante ;}
				}
			}
			
			public ComprobantesConDatosPrevios()
			{
			}
			public void Add( string _idComprobante, string _idTipoDeComprobante )
			{
				this.List.Add( new ComprobanteConDatosPrevios( _idComprobante, _idTipoDeComprobante ));
			}
			#region Miembros de IEnumerator
			int i=-1;
			public void Reset()
			{
				i=-1;
			}


			public object Current
			{
				get
				{
					if (i > 0 && i<this.List.Count)
						return this.List[i];
					return null;
				}
			}

			public bool MoveNext()
			{
				if (i< this.List.Count -1 )
				{
					i++;
					return true;
				}
				else
				{
					return false;
				}

			}

			#endregion
		}
		private object _maintask;
		private ProcessManager _process;
		private string _taskName;
		public ComprobantesConDatosPrevios DatosPrevios = new ComprobantesConDatosPrevios();
		/// <summary>
		/// Al momento de crearse esta clase la tarea principal debe estar creado.
		/// Esta clase no puede ser nunca una tarea principal de un proceso
		/// </summary>
		public CapturarDatosPreviosComprobantes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
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
			

		public void ListenerTaskDependentChanged(object sender)
		{

		}
		
		/// <summary>
		/// Si el objeto que ha cambiado es la tarea principal ejecuta su accion de captura de datos previos
		/// </summary>
		/// <param name="sender"></param>
		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof( mz.erp.businessrules.ComprobantesPendientes) )
			{
				RelacionesComprobanteOrigenDestino relaciones = ((mz.erp.businessrules.ComprobantesPendientes)sender).RelacionesComprobanteOrigenDestino;
				if (relaciones != null)
				{
					BuscarDatosComprobantesPrevios( relaciones );
				}
				//this.Execute();
			}
			if (sender.GetType() == typeof( mz.erp.businessrules.SeleccionItemsPendientes) )
			{
				RelacionesComprobanteOrigenDestino relaciones = ((mz.erp.businessrules.SeleccionItemsPendientes)sender).RelacionesComprobanteOrigenDestino;
				if (relaciones != null)
				{
					BuscarDatosComprobantesPrevios( relaciones );
				}
				//this.Execute();
			}
			

		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación CapturarDatosPreviosComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			// TODO: agregar la implementación CapturarDatosPreviosComprobantes.Init
		}

		public bool IsValidForStartProcess()
		{
			_errors.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._process.Process.IdProcess,IdTarea, this);
			_errors.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			// TODO: agregar la implementación CapturarDatosPreviosComprobantes.IsValid
			return true;
		}
		public bool AllowShow() 
		{
			return true;
		}
		public void FormHasClosed() 
		{
		}
		ItemsDatasetErrors _errors = new ItemsDatasetErrors();
		public ItemsDatasetErrors GetErrors()
		{
			return _errors;
			
		}
		public string GetWarnings()
		{
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _process;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_maintask = processManager.Process.MainTask.TaskInstance;
			_process= processManager;
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
			if (this.OnTaskBeforeExecute != null)
				OnTaskBeforeExecute( this, new System.EventArgs());
			if (this.OnTaskAfterExecute != null)
				OnTaskAfterExecute( this, new System.EventArgs());
		}

		#endregion
		#region Metodos Privados
		/// <summary>
		/// Convierte las Variable que establece la relacion con comprobantes previos del formato COPD:RMX a COPD, obteniendo solo el comprobante origen
		/// </summary>
		/// <returns>Una lista separada con comas con todos los comprobantes origenes para esa tarea</returns>
		private string GetTipoDeComprobante()
		{
			string _maintaskName = ((ITask)this._maintask).GetTaskName();
			string[]  relaciones= Variables.GetValueString( "Momentos."+this.GetTaskName()+"."+_maintaskName +"."+this._process.Process.ProcessName+".RelacionComprobantesPrevios" ).Split(',');
			string tipos = "";
			for (int i=0;i<relaciones.Length;i++)
			{
				string[] tupla = relaciones[i].Split(':');
				if (tupla.Length == 2 )
				{
					tipos+= tupla[0]+",";
				}
			}
			return tipos;
		}
		
		private void BuscarDatosComprobantesPrevios( mz.erp.businessrules.comprobantes.RelacionesComprobanteOrigenDestino relaciones )
		{
			string tipos = GetTipoDeComprobante();
			Hashtable hash = BuscarDatosEnPrimeraInstancia( tipos, relaciones );
			if (hash.Count == 0)
			{
				hash = BuscarDatosEnInstanciasPrevias( tipos, relaciones );
			}
			string idcomprobanteConDatosOrigen= null;
			if (hash.Count > 0)
			{
				foreach( string id in hash.Keys)
				{
					idcomprobanteConDatosOrigen = Convert.ToString(id) ;
				}
				this.DatosPrevios.Add( idcomprobanteConDatosOrigen, GetTipoDeComprobante( idcomprobanteConDatosOrigen ) );

			}
			
			
			if (this.ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}

		}
		
		private Hashtable BuscarDatosEnPrimeraInstancia(  string tiposdecomprobante, RelacionesComprobanteOrigenDestino relaciones )
		{
			Hashtable hash = new Hashtable();
			string[] tipos = tiposdecomprobante.Split(',');
			foreach( RelacionComprobanteOrigenDestino rol in relaciones )
			{
				for (int i=0;i<tipos.Length;i++)
				{
					if (tipos[i].CompareTo(rol.IdTipoDeComprobante )==0 )
					{
						if (!hash.ContainsKey( rol.IdComprobante ))
						{
							hash.Add( rol.IdComprobante, rol.IdComprobante);
						}
					}
				}
			}
			return hash;

		}
		private Hashtable BuscarDatosEnInstanciasPrevias(  string tiposdecomprobante, RelacionesComprobanteOrigenDestino relaciones )
		{
			Hashtable comprobantesOrigen = new Hashtable();
			Hashtable hash = new Hashtable();
			foreach( RelacionComprobanteOrigenDestino rol in relaciones )
			{
				if (!comprobantesOrigen.ContainsKey( rol.IdComprobante ))
				{
					comprobantesOrigen.Add( rol.IdComprobante, rol.IdComprobante );
				}
			}
			hash = BuscarEnComprobantesOrigen( tiposdecomprobante, comprobantesOrigen );
			return hash;

		}

		private Hashtable BuscarEnComprobantesDestino(string tiposdecomprobante, Hashtable comprobantesOrigen  )
		{
			Hashtable hash = new Hashtable();
			Hashtable hashOtros = new Hashtable();
			string[] tipos = tiposdecomprobante.Split(',');
			foreach (string idcomprobantedestino in comprobantesOrigen.Keys)
			{
				mz.erp.commontypes.data.tsa_ComprobantesRelacionOrigenDestinoDataset data = mz.erp.businessrules.tsa_ComprobantesRelacionOrigenDestino.GetList( idcomprobantedestino , null, long.MinValue,long.MinValue);
				if (data.tsa_ComprobantesRelacionOrigenDestino.Rows.Count>0)
				{
					mz.erp.commontypes.data.tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoRow row = (mz.erp.commontypes.data.tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoRow)data.tsa_ComprobantesRelacionOrigenDestino.Rows[0];
					if (!row.IsIdComprobanteDestinoNull())
					{
						string tipoOrigen = GetTipoDeComprobante( row.IdComprobanteDestino );
						bool contain = false;
						for (int i=0;i<tipos.Length;i++)
						{
							if (tipos[i].CompareTo(tipoOrigen )==0)
							{
								if (!hash.ContainsKey( row.IdComprobanteDestino ))
								{
									hash.Add( row.IdComprobanteDestino, row.IdComprobanteDestino);
								}
							}
							else
							{
								if (!hashOtros.ContainsKey( row.IdComprobanteDestino ))
								{
									hashOtros.Add( row.IdComprobanteDestino, row.IdComprobanteDestino);
								}
							}
						}
					}

				}
			}
			if (hash.Count == 0)
			{
				if (hashOtros.Count > 0)
				{
					hash = this.BuscarEnComprobantesDestino( tiposdecomprobante, hashOtros );
				}
			}

			return hash;
		}
		private Hashtable BuscarEnComprobantesOrigen(string tiposdecomprobante, Hashtable comprobantesOrigen  )
		{
			Hashtable hash = new Hashtable();
			Hashtable hashOtros = new Hashtable();
			string[] tipos = tiposdecomprobante.Split(',');
			foreach (string idcomprobantedestino in comprobantesOrigen.Keys)
			{
				mz.erp.commontypes.data.tsa_ComprobantesRelacionOrigenDestinoDataset data = mz.erp.businessrules.tsa_ComprobantesRelacionOrigenDestino.GetList( null , idcomprobantedestino, long.MinValue,long.MinValue);
				if (data.tsa_ComprobantesRelacionOrigenDestino.Rows.Count>0)
				{
					mz.erp.commontypes.data.tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoRow row = (mz.erp.commontypes.data.tsa_ComprobantesRelacionOrigenDestinoDataset.tsa_ComprobantesRelacionOrigenDestinoRow)data.tsa_ComprobantesRelacionOrigenDestino.Rows[0];
					if (!row.IsIdComprobanteOrigenNull())
					{
						string tipoOrigen = GetTipoDeComprobante( row.IdComprobanteOrigen );
						bool contain = false;
						for (int i=0;i<tipos.Length;i++)
						{
							if (tipos[i].CompareTo(tipoOrigen )==0)
							{
								if (!hash.ContainsKey( row.IdComprobanteOrigen ))
								{
									hash.Add( row.IdComprobanteOrigen, row.IdComprobanteOrigen);
								}
							}
							else
							{
								if (!hashOtros.ContainsKey( row.IdComprobanteOrigen ))
								{
									hashOtros.Add( row.IdComprobanteOrigen, row.IdComprobanteOrigen);
								}
							}
						}	
					}
				}
			}
			if (hash.Count == 0)
			{
				if (hashOtros.Count > 0)
				{
					hash = this.BuscarEnComprobantesOrigen( tiposdecomprobante, hashOtros );
					if (hash.Count == 0)
					{
						hash = this.BuscarEnComprobantesDestino( tiposdecomprobante, hashOtros );
					}
				}
			}
			return hash;
		}
		private string GetTipoDeComprobante( string IdComprobante)
		{
			mz.erp.commontypes.data.tsa_ComprobantesDataset.tsa_ComprobantesRow row = mz.erp.businessrules.tsa_Comprobantes.GetByPk( IdComprobante );
			if (row != null)
			{
				return row.IdTipoDeComprobante;
			}
			else
			{
				return string.Empty;
			}
		}
		#endregion
	}
}
