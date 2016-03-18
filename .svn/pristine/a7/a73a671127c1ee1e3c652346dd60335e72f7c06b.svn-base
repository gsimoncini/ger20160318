using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de TransferirValores.
	/// </summary>
	public class TransferirValores: ITask , IPersistentTask
	{
		public TransferirValores()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		#region Eventos y delegados
		
		#endregion

		#region variables 
			private string _textoBotonAnterior = "Anterior";
			private string _textoBotonSiguiente = "Siguiente";

			private DataSet _dataMovimientosO = null;
			private DataSet _dataPagosMovimientosO = null;
			private DataSet _dataMovimientosD = null;
			private DataSet _dataPagosMovimientosD = null;
			

			TransferenciaValores _transferencia;
			private string _taskName = string.Empty;
			private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
			private ProcessManager _processParent;

		#endregion

		#region propiedades

		public string IdMovimientoOrigen
		{
			get 
			{
				return _transferencia.IdMovimientoOrigen;
			}
		}		

		
		public string IdMovimientoDestino
		{
			get 
			{
				return _transferencia.IdMovimientoDestino;
			}
		}		

		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
				}				
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}
	
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}

	

		public string KeyValueCajaOrigen 
		{
			get 
			{
				return _transferencia.KeyValueCajaOrigen;
			}
			set 
			{
				_transferencia.KeyValueCajaOrigen = value;
			}
		}
		public string KeyValueCajaDestino
		{
			get 
			{
				return _transferencia.KeyValueCajaDestino;
			}
			set 
			{
				_transferencia.KeyValueCajaDestino = value;
			}
		}

		
		public string ResponsableCajaOrigen
		{
			get 
			{
				return _transferencia.ResponsableCajaOrigen;
			}
			set 
			{
				if (_transferencia.ResponsableCajaOrigen.CompareTo(value) != 0 )
				{
					_transferencia.ResponsableCajaOrigen = value;

					if (this.ObjectHasChanged != null)
						ObjectHasChanged(this, new System.EventArgs());
				}
			}
		}

		public string ResponsableCajaDestino
		{
			get 
			{
				return _transferencia.ResponsableCajaDestino;
			}
			set 
			{
				if (_transferencia.ResponsableCajaDestino.CompareTo(value) != 0 )
				{
					_transferencia.ResponsableCajaDestino = value;

					if (this.ObjectHasChanged != null)
						ObjectHasChanged(this, new System.EventArgs());
				}
			}
		}
		


		public ArrayList ValoresDisponibles 
		{
			get 
			{
				return _transferencia.ValoresDisponibles;
			}
						
		}

		public ArrayList ValoresATransferir 
		{
			get 
			{
				return _transferencia.ValoresATransferir;
			}
		}


		public void Transferir(ArrayList array) 
		{
			_transferencia.Transferir(array);
		}
		public void TransferirTodo() 
		{
			_transferencia.TransferirTodo();
		}
		public void Remover(ArrayList array) 
		{
			_transferencia.Remover(array);
		}
		public void RemoverTodo() 
		{
			_transferencia.RemoverTodo();
		}
		public void RefreshDataOrigen() 
		{
			_transferencia.RefreshDataOrigen();
		}
		public decimal TotalATransferir
		{
			get 
			{
				return _transferencia.TotalATransferir;
			}
		}
		public Hashtable CajasOrigenDisponibles 
		{
			get {return _transferencia.CajasOrigenDisponibles;}
		}
		public Hashtable CajasDestinoDisponibles 
		{
			get {return  _transferencia.CajasDestinoDisponibles;}
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
			this.AllowPrevious();
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

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
		}

		public void Init()
		{			
			_transferencia = new TransferenciaValores();
			_transferencia.Init(this.GetTaskName(), this._processParent.Process.ProcessName );
			_transferencia.OnObjectHasChanged += new EventHandler(_transferencia_OnObjectHasChanged);
			
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			
			foreach (DetalleValorMovimiento valor in _transferencia.ValoresATransferir)  
			{
				if (valor.ValorDestino > valor.ValorOrigen) 
				{
					IsValid = true;	
					_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valor","Ha ocurrido un error en el ingreso manual de valores."));
				}
				if (valor.ValorOrigen != valor.ValorDestino && !valor.Agrupado) 
				{
					IsValid = true;	
					_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valor","Ha ocurrido un error en el ingreso manual de valores."));
				}
			}
			if (_transferencia.ValoresATransferir.Count == 0) 
			{
				IsValid = true;	
				_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valores","No hay valores seleccionados para transferir."));
			}
			if (_transferencia.KeyValueCajaOrigen == _transferencia.KeyValueCajaDestino) 
			{
				IsValid = true;	
				_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Cajas","Las instancias de caja deben ser distintas."));
			}

            /* Silvina 20100531 - Tarea 776 */
            if ((_transferencia.KeyValueCajaDestino != null) && (_transferencia.KeyValueCajaDestino != string.Empty))
            {
            /* Fin Silvina */
                tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow rowInstanciaDeCaja = mz.erp.dataaccess.tfi_InstanciasCaja.GetByPk(_transferencia.KeyValueCajaDestino);
                if (!rowInstanciaDeCaja.IsCierreNull())
                {
                    IsValid = false;
                    _errores.Add(new ItemDatasetError(this._processParent.Process.ProcessName, "Cajas", "La instancia de caja destino esta cerrada."));
                }
            }
            /*Silvina 20100531 - Tarea 776 */
            else
            {
                IsValid = false;
                _errores.Add(new ItemDatasetError(this._processParent.Process.ProcessName, "Cajas", "Debe seleccionar una Caja destino."));
            }
            /* Fin Silvina */

			return IsValid;
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

		#region Miembros de IPersistentTask
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( this._dataMovimientosD );
			data.Add( this._dataMovimientosO );
			data.Add( this._dataPagosMovimientosD );
			data.Add( this._dataPagosMovimientosO );
			return data;
		}

		public void Commit()
		{
			_transferencia.Commit();
			this._dataMovimientosD = _transferencia.DataMovimientosD;
			this._dataMovimientosO = _transferencia.DataMovimientosO;
			this._dataPagosMovimientosO = _transferencia.DataPagosMovimientosO;
			this._dataPagosMovimientosD = _transferencia.DataPagosMovimientosD;
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			_transferencia.Flush(IdTransaction);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación TransferirValores.PutExtraDataOnCommit
		}

		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{
			foreach( TaskCollectionData _collectionTask in _processCollectionData)
			{
				#region Aceptacion
				if (_collectionTask.TaskName.Equals("Aceptacion")) 
				{
					string idAceptacion = null;
					//obtengo el idaceptacion real
					foreach (System.Data.DataSet dataAceptacion in _collectionTask )
					{
						if(dataAceptacion.Tables["tsh_Aceptacion"].Rows.Count > 0)
							idAceptacion = Convert.ToString(dataAceptacion.Tables["tsh_Aceptacion"].Rows[0]["IdAceptacion"]);
					}
					//guardo el id aceptacion para el movimiento origen
					foreach (System.Data.DataRow row in  this._dataMovimientosO.Tables["tfi_MovimientosDeCaja"].Rows)
					{
						row["IdAceptacion"]= idAceptacion;
					}
					//guardo el id de acepptacion para el movimiento destino
					foreach (System.Data.DataRow row in  this._dataMovimientosD.Tables["tfi_MovimientosDeCaja"].Rows)
					{
						row["IdAceptacion"]= idAceptacion;
					}
				}
				#endregion
			}
		}		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _transferencia.GenerateReplication();
		}
		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
		
		#endregion

		private void _transferencia_OnObjectHasChanged(object sender, EventArgs e)
		{
			if (ObjectHasChanged != null)
			{
				ObjectHasChanged(this, new EventArgs());
			}
		}
	}
}
