using System;
using mz.erp.businessrules.comprobantes;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de RecargosFormasDePago.
	/// </summary>
	public class RecargosFormasDePago:ITask
	{
		public RecargosFormasDePago()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		#region Variables Privadas
		
			private FormasDePagos _formasDePagos;
			private RecargosFormaDePago _recargos;
			private decimal _totalNetoComprobanteDeVenta;
			private decimal _totalConImpuestosSinRecargosComprobanteDeVenta;
			private decimal _totalComprobantedDeVenta;
			private decimal _totalConImpuestoComprobanteDeVenta;

		private decimal _totalNetoComprobanteDeVentaOrigen;
		private decimal _totalConImpuestosSinRecargosComprobanteDeVentaOrigen;
		private decimal _totalComprobantedDeVentaOrigen;
		private decimal _totalConImpuestoComprobanteDeVentaOrigen;

		private decimal _totalNetoComprobanteDeVentaDestino;
		private decimal _totalConImpuestosSinRecargosComprobanteDeVentaDestino;
		private decimal _totalComprobantedDeVentaDestino;
		private decimal _totalConImpuestoComprobanteDeVentaDestino;

			ProcessManager _processParent = null;
			private string _taskName = null;
			private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
			private bool _allowShow = true;
			private bool _allowShowVariable = true ;
			
			private mz.erp.businessrules.comprobantes.CondicionDeVenta _condicionDeVenta;
			private mz.erp.businessrules.comprobantes.CondicionDeVenta _condicionDeVentaOrigen;
			private mz.erp.businessrules.comprobantes.CondicionDeVenta _condicionDeVentaDestino;
			private string _idCondicionDeVenta = string.Empty;
			private string _idComprobanteDeVentaStep = null;
			private string _idCondicionDeVentaStep = null;
			private decimal _totalNetoComprobanteDeVentaStep = decimal.MinValue;	
			private RelacionesComprobanteOrigenDestino _relacionesComprobanteOrigenDestino;


			private bool _modified = false;	
			private bool _totalNetoComprobanteDeVentaChanged = false;
			
			private string _idCuenta = string.Empty;
			private string _idTipoDeComprobante = string.Empty;

		/*Esta variable controla si los valores se generan nuevamente o se mantiene el mismo valor*/
		/*El valor de esta variable debe ser el mismo q la variable q se usa en la clase ComprobanteDePago*/
		private bool _creaIdValoresNuevos = true;


		private bool _procesoCambiarMercaderiaVisualizaVentana = true;


			




		#endregion

		#region Variables Publicas


		public decimal TotalFinalComprobanteDeVenta
		{
			get
			{
				return _totalComprobantedDeVenta;
			}
		}

		
		public bool CreaIdValoresNuevos
		{
			get{return _creaIdValoresNuevos;}
		}
		

		public string IdCuenta
		{
			get 
			{
				return this._idCuenta;
			}
		}

		public decimal Saldo
		{
			get
			{
				return this.TotalComprobanteDeVenta - this._recargos.Total;
			}
		}


		public string CondicionDeVenta
		{
			get
			{
				if(_condicionDeVenta != null)
					return _condicionDeVenta.Descripcion;
				else return string.Empty;
			}
		}

		public int CuotasCondicionDeVenta
		{
			get
			{
				if(_condicionDeVenta != null)
					return _condicionDeVenta.DetalleCondicionDeVenta.Count;
				else return 0;
			}

		}

		public decimal RecargoCondicionDeVenta
		{
			get
			{
				if(_condicionDeVenta != null)
					return decimal.Round(_condicionDeVenta.Recargo,2);
				else return 0;
			}
		}

		public decimal TotalAAbonar
		{
			get
			{
				return  this._totalConImpuestoComprobanteDeVenta - this._recargos.Total;
			}
		}
		
		public FormasDePagos FormasDePagos
		{
			get
			{
				return _formasDePagos;
			}
			set
			{
				_formasDePagos = value;
			}
		}

		public RecargosFormaDePago Recargos
		{
			get
			{
				return _recargos;
			}
			set
			{
				_recargos = value;
			}
		}

		public decimal TotalComprobanteDeVentaSinRecargos
		{
			get
			{
				return decimal.Round(this._totalConImpuestosSinRecargosComprobanteDeVenta,2);
			}
		}

		public decimal TotalComprobanteDeVenta
		{
			get
			{
				return decimal.Round(_totalConImpuestoComprobanteDeVenta,2);
			}
		}

		public decimal PorcentualRecargosFinancieros
		{
			get
			{
				
				decimal porcentual = 0;
                /* Silvina 20110211 - Tarea 0000030 */
                /* Silvina 20110905 - Tarea 0000206 */
                decimal aux = _totalConImpuestosSinRecargosComprobanteDeVenta + _totalConImpuestosSinRecargosComprobanteDeVenta * this.RecargoCondicionDeVenta / 100;
                if (aux != 0)
                    porcentual = this._recargos.TotalImporteRecargo * 100 / aux;
                    /* Fin Silvina 20110905 - Tarea 0000206 */
                /* Fin Silvina */
				return porcentual;
				/*
				return decimal.Round(_recargos.TotalPorcentajeRecargo,2);
				if(_recargos.TotalImporteAbonado > 0)
					return _recargos.TotalImporteRecargo * 100 / _recargos.TotalImporteAbonado;
				return 0;
				*/
			}
		}

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = string.Empty;
				try 
				{
					string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
					valor = Variables.GetValueString(variable);
					if (valor == String.Empty)
					{
						variable = "Sistema.Interfaz.TextoBotonAnterior";
						valor = Variables.GetValueString(variable);				
					}
				}
				catch 
				{
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
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{				
				string valor = string.Empty;
				try 
				{
					string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);
					if (valor == String.Empty)
					{
						variable = "Sistema.Interfaz.TextoBotonSiguiente";
						valor = Variables.GetValueString(variable);				
					}
				}
				catch 
				{
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
		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler RecargoFinancieroChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			this._totalNetoComprobanteDeVentaChanged = false;
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta)))
			{
				this._totalNetoComprobanteDeVentaChanged = false;
				this._modified = false;
			}
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		string _idComprobanteDeVentaOrigen = string.Empty;
		bool _idComprobanteDeVentaOrigenChanged = false;
		public void ListenerTaskDependentChanged(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta)))
			{
				
				ITask taskInfo = (ITask)sender;
				if(!taskInfo.GetTaskName().Equals("AnularPrevender")&&!taskInfo.GetTaskName().Equals("AnularPreprestar")
                    //German 20111202 - Tarea 0000232
                    &&!(this.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoPrevenderReserva") && taskInfo.GetTaskName().Equals("Vender"))
                    //Fin German 20111202 - Tarea 0000232
                    )
				{
					ComprobanteDeVenta comprobanteDeVenta = (ComprobanteDeVenta)sender;
					
				
					if(! (this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas")
						|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")))
					{
					
						_totalNetoComprobanteDeVentaChanged = this._totalNetoComprobanteDeVenta != comprobanteDeVenta.TotalNeto || _totalNetoComprobanteDeVentaChanged;// && !_idComprobanteDeVentaOrigenChanged;
						if(_totalNetoComprobanteDeVentaChanged )//|| _condicionDeVentaChanged)
						{
						
							this._totalConImpuestoComprobanteDeVenta = comprobanteDeVenta.TotalConImpuestos;
							this._totalNetoComprobanteDeVenta = comprobanteDeVenta.TotalNeto;
							this._totalConImpuestosSinRecargosComprobanteDeVenta = comprobanteDeVenta.TotalConImpuestosSinRecargos;
						
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
						
						}
					}
					else
					{
						if((this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas")
							|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")))
						{
					
							if(this._taskName.Equals("Devolver"))
							{
								this._totalConImpuestoComprobanteDeVentaOrigen = comprobanteDeVenta.TotalConImpuestos;
								this._totalNetoComprobanteDeVentaOrigen = comprobanteDeVenta.TotalNeto;
								this._totalConImpuestosSinRecargosComprobanteDeVentaOrigen = comprobanteDeVenta.TotalConImpuestosSinRecargos;
								this._totalComprobantedDeVentaOrigen = comprobanteDeVenta.Total;
								this._condicionDeVentaOrigen = comprobanteDeVenta.CondicionDeVenta;
						
							}
							else
							{
								if(this._taskName.Equals("Vender") ||this._taskName.Equals("Prestar"))
								{
									
									
									_totalNetoComprobanteDeVentaChanged = (this._totalNetoComprobanteDeVenta != (comprobanteDeVenta.TotalNeto - _totalNetoComprobanteDeVentaOrigen)) || _totalNetoComprobanteDeVentaChanged;// && !_idComprobanteDeVentaOrigenChanged;
						
									
									this._totalConImpuestoComprobanteDeVentaDestino = comprobanteDeVenta.TotalConImpuestos;
									this._totalNetoComprobanteDeVentaDestino = comprobanteDeVenta.TotalNeto;
									this._totalConImpuestosSinRecargosComprobanteDeVentaDestino = comprobanteDeVenta.TotalConImpuestosSinRecargos;
									this._totalComprobantedDeVentaDestino = comprobanteDeVenta.Total;
									this._condicionDeVentaDestino = comprobanteDeVenta.CondicionDeVenta;


									if(_totalNetoComprobanteDeVentaChanged )//|| _condicionDeVentaChanged)
									{
										this._totalConImpuestoComprobanteDeVenta = _totalConImpuestoComprobanteDeVentaDestino - _totalConImpuestoComprobanteDeVentaOrigen;
										this._totalNetoComprobanteDeVenta =_totalNetoComprobanteDeVentaDestino - _totalNetoComprobanteDeVentaOrigen;
										this._totalConImpuestosSinRecargosComprobanteDeVenta = _totalConImpuestosSinRecargosComprobanteDeVentaDestino - _totalConImpuestosSinRecargosComprobanteDeVentaOrigen;
										this._totalComprobantedDeVenta = _totalComprobantedDeVentaDestino - _totalComprobantedDeVentaOrigen;
									
										//Significa que el cliente acredita mas de lo que debita, por ende no hay que mostrar la ventana de formas de pagos
										if(_totalComprobantedDeVenta < 0)
											_procesoCambiarMercaderiaVisualizaVentana = false;

										if(ObjectHasChanged != null)
											ObjectHasChanged(this, new EventArgs());
									}
								}
							}
							/*
							_totalNetoComprobanteDeVentaChanged = this._totalNetoComprobanteDeVenta != comprobanteDeVenta.TotalNeto || _totalNetoComprobanteDeVentaChanged;// && !_idComprobanteDeVentaOrigenChanged;
							if(_totalNetoComprobanteDeVentaChanged )//|| _condicionDeVentaChanged)
							{
						
								this._totalConImpuestoComprobanteDeVenta = comprobanteDeVenta.TotalConImpuestos;
								this._totalNetoComprobanteDeVenta = comprobanteDeVenta.TotalNeto;
								this._totalConImpuestosSinRecargosComprobanteDeVenta = comprobanteDeVenta.TotalConImpuestosSinRecargos;
						
								if(ObjectHasChanged != null)
									ObjectHasChanged(this, new EventArgs());
						
							}
							*/
						}
					}
				}
			}
		}

		private void AddFormaDePagoDefault()
		{
			if(_idFormaDePagoDefault != null && !_idFormaDePagoDefault.Equals(string.Empty) /*&& !IsStep()*/)	
			{
				if(_recargos.Count == 0)
				{
					FormaDePago fdp = _formasDePagos.GetByTDCompMoneda(_idFormaDePagoDefault,"1");
					if(fdp != null)
					{
						FormaDePago formaDePago = fdp.ShallowClone();
						Valor valor = new Valor(null, fdp.IdTDComprobante,fdp.IdMoneda,this._totalConImpuestoComprobanteDeVenta);
						formaDePago.Valor = valor;
						_recargos.AddRecargo(formaDePago, this._totalConImpuestoComprobanteDeVenta);
					}
				}

			}
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta)))
			{
				_procesoCambiarMercaderiaVisualizaVentana = true;
				ITask taskInfo = (ITask)sender;
				if(!taskInfo.GetTaskName().Equals("AnularPrevender")&&!taskInfo.GetTaskName().Equals("AnularPreprestar")
                    
                    //German 20111202 - Tarea 0000232
                    &&!(this.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoPrevenderReserva") && taskInfo.GetTaskName().Equals("Vender"))
                    //Fin German 20111202 - Tarea 0000232
                    )
				{
					ComprobanteDeVenta comprobanteDeVenta = (ComprobanteDeVenta)sender;
					bool _condicionDeVentaChanged = this._idCondicionDeVenta != comprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta;
					_idComprobanteDeVentaOrigen = comprobanteDeVenta.IdComprobanteOrigen;
					_idCondicionDeVenta = comprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta;
					this._condicionDeVenta = comprobanteDeVenta.CondicionDeVenta;
					
					if(! (this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas")
						|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")))
					{
					
						this._totalNetoComprobanteDeVenta = comprobanteDeVenta.TotalNeto;
						this._totalConImpuestosSinRecargosComprobanteDeVenta = comprobanteDeVenta.TotalConImpuestosSinRecargos;
						this._totalConImpuestoComprobanteDeVenta = comprobanteDeVenta.TotalConImpuestos;
					}
					else
					{
						if((this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas")
							|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")))
						{
					
							if(taskInfo.GetTaskName().Equals("Devolver"))
							{
								this._totalConImpuestoComprobanteDeVentaOrigen = comprobanteDeVenta.TotalConImpuestos;
								this._totalNetoComprobanteDeVentaOrigen = comprobanteDeVenta.TotalNeto;
								this._totalConImpuestosSinRecargosComprobanteDeVentaOrigen = comprobanteDeVenta.TotalConImpuestosSinRecargos;
								this._totalComprobantedDeVentaOrigen = comprobanteDeVenta.Total;
								this._condicionDeVentaOrigen = comprobanteDeVenta.CondicionDeVenta;
						
							}
							else
							{
								if(taskInfo.GetTaskName().Equals("Vender") ||taskInfo.GetTaskName().Equals("Prestar"))
								{
									this._totalConImpuestoComprobanteDeVentaDestino = comprobanteDeVenta.TotalConImpuestos;
									this._totalNetoComprobanteDeVentaDestino = comprobanteDeVenta.TotalNeto;
									this._totalConImpuestosSinRecargosComprobanteDeVentaDestino = comprobanteDeVenta.TotalConImpuestosSinRecargos;
									this._totalComprobantedDeVentaDestino = comprobanteDeVenta.Total;
									this._condicionDeVentaDestino = comprobanteDeVenta.CondicionDeVenta;

									
									this._totalConImpuestoComprobanteDeVenta = _totalConImpuestoComprobanteDeVentaDestino - _totalConImpuestoComprobanteDeVentaOrigen;
									this._totalNetoComprobanteDeVenta =_totalNetoComprobanteDeVentaDestino - _totalNetoComprobanteDeVentaOrigen;
									this._totalConImpuestosSinRecargosComprobanteDeVenta = _totalConImpuestosSinRecargosComprobanteDeVentaDestino - _totalConImpuestosSinRecargosComprobanteDeVentaOrigen;
									this._totalComprobantedDeVenta = _totalComprobantedDeVentaDestino - _totalComprobantedDeVentaOrigen;

									//Significa que el cliente acredita mas de lo que debita, por ende no hay que mostrar la ventana de formas de pagos
									if(_totalComprobantedDeVenta < 0)
										_procesoCambiarMercaderiaVisualizaVentana = false;

								}
							}
						}
					}
					
					bool _idCuentaChanged = comprobanteDeVenta.Cuenta.IdCuenta != null &&
						comprobanteDeVenta.Cuenta.IdCuenta != string.Empty &&
						comprobanteDeVenta.Cuenta.IdCuenta != _idCuenta;
					bool _idTipoDeComprobanteChanged =  comprobanteDeVenta.TipoComprobanteDestino != null &&
						comprobanteDeVenta.TipoComprobanteDestino != string.Empty &&
						comprobanteDeVenta.TipoComprobanteDestino != _idTipoDeComprobante;
					this._idCuenta = comprobanteDeVenta.Cuenta.IdCuenta;
					this._idTipoDeComprobante = comprobanteDeVenta.TipoComprobanteDestino;
					if(_condicionDeVentaChanged || _idCuentaChanged || _idTipoDeComprobanteChanged)
						_formasDePagos = mz.erp.businessrules.tfi_FormasDePagoEx.GetFormasDePago(_condicionDeVenta.IdCondicionDeVenta,this._idCuenta, this._idTipoDeComprobante);
					
					AddFormaDePagoDefault();
					if(_condicionDeVentaChanged && !IsStep()  && !_totalNetoComprobanteDeVentaChanged )
					{
						if(MustResetRecargos())
						{
							ResetRecargos();
						}
					
					}
					else
					{
						if(!IsStep()  && _totalNetoComprobanteDeVentaChanged)
						{
							if(MustResetRecargos())
							{
								ResetRecargos();
							}
						}
						else
						{
							if(IsStep()&& ((_idCondicionDeVentaStep ==  null || 
								_idCondicionDeVentaStep.Equals(_idCondicionDeVenta))
								&& (	_totalNetoComprobanteDeVentaStep == decimal.MinValue ||
								_totalNetoComprobanteDeVentaStep.Equals(_totalNetoComprobanteDeVenta))
								&& (	_idComprobanteDeVentaStep == null||
								_idComprobanteDeVentaStep.Equals(_idComprobanteDeVentaOrigen))
								)
								)
							{
							
								this._totalNetoComprobanteDeVentaStep = this._totalNetoComprobanteDeVenta;
								this._idCondicionDeVentaStep = this._idCondicionDeVenta;
								this._idComprobanteDeVentaStep = _idComprobanteDeVentaOrigen;
								this._totalComprobantedDeVenta = comprobanteDeVenta.Total;
								this.Step();
							}
						
							else
							{
								if(IsStep() && (!_idCondicionDeVentaStep.Equals(_idCondicionDeVenta)
									|| !_totalNetoComprobanteDeVentaStep.Equals(_totalNetoComprobanteDeVenta)
									)&& _idComprobanteDeVentaStep.Equals(_idComprobanteDeVentaOrigen))
								{
									this._idCondicionDeVentaStep = this._idCondicionDeVenta;
									this._totalComprobantedDeVenta = comprobanteDeVenta.Total;
									if(MustResetRecargos())
									{
										ResetRecargos();
									}
								}
								else
								{
									if(IsStep() && !_idComprobanteDeVentaStep.Equals(_idComprobanteDeVentaOrigen))
									{
										this._modified = false;
										ResetRecargos();
										this._idComprobanteDeVentaStep = _idComprobanteDeVentaOrigen;
										this._totalNetoComprobanteDeVentaStep = this._totalNetoComprobanteDeVenta;
										this._idCondicionDeVentaStep = this._idCondicionDeVenta;
										this._totalComprobantedDeVenta = comprobanteDeVenta.Total;
										this.Step();
										
									}
								}
							}
						
						}
					}
					_allowShow = _formasDePagos.Count>0;//!(_formasDePagos.Count == 0 || (_formasDePagos.Count == 1 && _recargos.Count == 1 ));
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
			
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionItemsPendientes)))
			{
				SeleccionItemsPendientes ItemsPendientes = (SeleccionItemsPendientes)sender;
				if(ItemsPendientes.RelacionesComprobanteOrigenDestino != null && ItemsPendientes.RelacionesComprobanteOrigenDestino.Count > 0)
				{
					this._relacionesComprobanteOrigenDestino = ItemsPendientes.RelacionesComprobanteOrigenDestino;
				}

			}
			
			
		}

		private bool MustResetRecargos()
		{
			foreach(RecargoFormaDePago recargo in _recargos)
			{
				bool ok = true;
				int index = 0;
				while(ok && index < _formasDePagos.Count)
				{
						FormaDePago formaDePagoRecargo = recargo.FormaDePago;
						FormaDePago formaDePago = (FormaDePago)_formasDePagos[index];
						if(formaDePagoRecargo.IdFormaDePago != null && !formaDePagoRecargo.IdFormaDePago.Equals(string.Empty) && formaDePagoRecargo.IdFormaDePago.Equals(formaDePago.IdFormaDePago))
						{
							
							ok = false;
						}
						else
						{
							bool _isValid = formaDePago.IdTDComprobante.Equals(formaDePagoRecargo.IdTDComprobante) && 
								formaDePago.Recargo.Equals(formaDePagoRecargo.Recargo) && formaDePago.GetIdMoneda().Equals(formaDePagoRecargo.IdMoneda);
							if(_isValid)
							{
								
								ok = false;																	
							}

						}
					
						index++;
					
				}
				if(ok)
					return true;
			}
			return false;
		}
					


		private void ResetRecargos()
		{
			_recargos = new RecargosFormaDePago();
			_recargos.ImporteAbonadoChanged +=new EventHandler(_recargos_ImporteAbonadoChanged);
			_recargos.RecargosIncluidosChanged +=new EventHandler(_recargos_ImporteAbonadoChanged);
			_recargos.OnModified +=new EventHandler(_recargos_OnModified);
		}

		private bool IsStep()
		{
			return this._relacionesComprobanteOrigenDestino != null;
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

		private void Step()
		{
			if(!_modified)
			{
				_recargos.Clear();
				ArrayList formasDePago = new ArrayList();
				string IdComprobante = string.Empty;
				ArrayList arrayValores = new ArrayList();
				foreach(RelacionComprobanteOrigenDestino relacion in this._relacionesComprobanteOrigenDestino)
				{
					if(!IdComprobante.Equals(relacion.IdComprobante))
					{
						IdComprobante = relacion.IdComprobante;
						string IdCondicionDeVenta = relacion.IdCondicionDeVenta;
						ComprobanteDePago precomprobanteDePago = Factory.GetComprobanteDePago(IdComprobante, IdCondicionDeVenta);
						Valores valores = precomprobanteDePago.Valores;
					
						foreach(Valor valor in valores.MisValores)
						{
							bool ok = true;
							int index = 0;
							while(ok)
							{
								if(index < _formasDePagos.Count)
								{
									FormaDePago formaDePago = (FormaDePago)_formasDePagos[index];
									if(valor.IdFormaDePago != null && !valor.IdFormaDePago.Equals(string.Empty) && valor.IdFormaDePago.Equals(formaDePago.IdFormaDePago))
									{
										formasDePago.Add(formaDePago.ShallowClone());
										valor.IsStep = true;
										arrayValores.Add(valor);
										ok = false;
									}
									else
									{
										/*
										decimal _porcentajeRecargo = 0;
										if(valor.MontoCotizado > 0)
											_porcentajeRecargo = Math.Abs(decimal.Round((decimal.Round(valor.MontoCotizado,4) - decimal.Round(valor.MontoSinRecargos,4))*100/decimal.Round(valor.MontoSinRecargos,4),2));
										*/
										bool _isValid = formaDePago.IdTDComprobante.Equals(valor.IdTDCompTesoreria) && 
											/*formaDePago.Recargo.Equals(_porcentajeRecargo) &&*/ formaDePago.GetIdMoneda().Equals(valor.IdMoneda);
										if(_isValid)
										{
											formasDePago.Add(formaDePago.ShallowClone());
											arrayValores.Add(valor);
											valor.IsStep = true;
											ok = false;																	
										}

		
									}
									index++;
								}
								else ok = false;

							}
						}
					}
				}
				int i = 0;
				foreach(FormaDePago formaDePago in formasDePago)
				{
				
					Valor valor = (Valor) arrayValores[i];
					_recargos.AddRecargo(valor, formaDePago, this._totalConImpuestosSinRecargosComprobanteDeVenta, this._totalComprobantedDeVenta);
					i++;
				}
				/*
				if(_recargos.Count > 0)
				{
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
				*/
			}
			if(_recargos.Count == 0)
			{
				AddFormaDePagoDefault();
			}

		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación RecargosFormasDePago.ListenerBeforeExecuteDependentTask
		}

		
		private string _idFormaDePagoDefault = string.Empty;
		public void Init()
		{
			//_formasDePagos = mz.erp.businessrules.tfi_FormasDePagoEx.GetFormasDePago();
			_recargos = new RecargosFormaDePago();
			_recargos.ImporteAbonadoChanged +=new EventHandler(_recargos_ImporteAbonadoChanged);
			_recargos.RecargosIncluidosChanged +=new EventHandler(_recargos_ImporteAbonadoChanged);
			_reglasDeValidacion = Build_ReglasDeValidacion();
			_creaIdValoresNuevos = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"Step.Valores.CreaNuevosValores",true);
			_idFormaDePagoDefault = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName,"FormaDePago.Default");
			_allowShowVariable = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"MuestraFormulario", _allowShowVariable);
		
			
		}
		private Hashtable Build_ReglasDeValidacion()
		{
			Hashtable hash = new Hashtable();
			mz.erp.commontypes.data.tfi_TDCompTesoreriaDataset _dataIdTDCompTesoreria = mz.erp.businessrules.tfi_TDCompTesoreria.GetList();
			foreach (System.Data.DataRow _rowIdTDCompTesoreria in _dataIdTDCompTesoreria.tfi_TDCompTesoreria.Rows)
			{
				string idTipoDeComprobanteDeTesoreria = Convert.ToString( _rowIdTDCompTesoreria["IdTDCompTesoreria"] );
				string debevalidar = Variables.GetValueString("Momentos."+this.GetTaskName()+"."+this._processParent.Process.ProcessName+"."+mz.erp.businessrules.MAPStaticInfo.GetFDP(idTipoDeComprobanteDeTesoreria)+"."+"ObligaVarAuxiliares");
				hash.Add( idTipoDeComprobanteDeTesoreria, debevalidar );
			}
			return hash;
			
			
		}

		public void Refresh()
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		public bool IsValidObject
		{
			get
			{
				return _errores.Count == 0;
			}
		}

		public bool IsValid()
		{
			_errores.Clear();
			bool isvalid = true;
			if (this.GenerariaPagoACuenta())
			{
				ItemDatasetError error = new ItemDatasetError("Importe","Se generaría un Pago a Cuenta.","El importe de la forma de pago es mayor al importe de la factura. Funcionalidad no permitida.");
				_errores.Add( error );
				isvalid = false;			
			}
			if (!IsValidMonto())
				{
					ItemDatasetError error = new ItemDatasetError("Importe","Monto Insuficiente","El Total es menor que el total del Comprobante De Venta");
					_errores.Add( error );
					isvalid = false;
				}
			if(! IsValidValores())
			{
				ItemDatasetError error = new ItemDatasetError("Valores","Datos Insuficientes","Falta completar información para 'Medio de Pago' especificado.");
				_errores.Add( error );
				isvalid = false;

			}
			if(! IsValidFormaDePago())
			{
				ItemDatasetError error = new ItemDatasetError("Formas de Pagos","Recargos","No se puede seleccionar una forma de pago con recargos para este proceso. El recargo debe estar en la condición de venta.");
				_errores.Add( error );
				isvalid = false;
			}
			
            /* Silvina 20111212 - Tarea 0000232 */
            if (!IsValidMontoReserva())
            {
                ItemDatasetError error = new ItemDatasetError("Seña", "Seña", "El monto de la seña debe ser mayor a cero.");
                _errores.Add(error);
                isvalid = false;
            }
            /* Fin Silvina 20111212 - Tarea 0000232 */

			return isvalid;
					
		}

		private bool IsValidFormaDePago()
		{
			bool ok = true;
			
			if(this._processParent.Process.Equals("ProcesoCambiarMercaderiaVentas")
				|| this._processParent.Process.Equals("ProcesoCambiarMercaderiaVentasDV"))
			{
				foreach(RecargoFormaDePago rec in this._recargos)
				{
					ok = ok && (rec.PorcentajeRecargo == 0);
				}
			}
			return ok;
		}

		private bool IsValidValores()
		{
			bool ok = true;
			
			foreach(RecargoFormaDePago rec in this._recargos)
			{
				ok = ok && rec.FormaDePago.Valor.completoDatos(this._processParent.Process.ProcessName, this._taskName);
			}
			return ok;
		}

		private bool IsValidMonto()
		{
            //German 20111202 - Tarea 0000232
            if (this._processParent.Process.ProcessName.Equals("ProcesoPrevenderReserva")) return true;
            //Fin German 20111202 - Tarea 0000232

			if(!(this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas")
				|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")))
			{
				decimal totalCompVenta = this._condicionDeVenta.GetObligatoryPayment();
				if(decimal.Round(totalCompVenta,2) > decimal.Round(this._recargos.Total,2))
					return Math.Abs(decimal.Round(totalCompVenta,2) - decimal.Round(this._recargos.Total,2)) <= Convert.ToDecimal(0.04);
			}
			else
			{
				//Se asume que solo hay condiciones de vntas de una sola cuota
				if(decimal.Round(this._condicionDeVentaDestino.GetObligatoryPayment(_totalComprobantedDeVenta),2) > decimal.Round(this._recargos.Total,2))
					return Math.Abs(decimal.Round(this._condicionDeVentaDestino.GetObligatoryPayment(_totalComprobantedDeVenta),2) - decimal.Round(this._recargos.Total,2)) <= Convert.ToDecimal(0.04);
			}
			return true;
		}

        /* Silvina 20111212 - Tarea 0000232 */

        private bool IsValidMontoReserva()
        {
            return (!this._processParent.Process.ProcessName.Equals("ProcesoPrevenderReserva") || _recargos.Total > 0);
        }

        /* Fin Silvina 20111212 - Tarea 0000232 */

		public ItemsDatasetErrors GetErrors()
		{
			return _errores;
		}

		public bool GenerariaPagoACuenta()
		{
			if(!(this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas")
				|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")))
			{
				return (System.Math.Round(_recargos.Total,2) > System.Math.Round(this.TotalComprobanteDeVenta,2) );
			}
			else
			{
				if (this.TotalComprobanteDeVenta < 0) 
					return false;
				else
					return (System.Math.Round(_recargos.Total,2) > System.Math.Round(this.TotalComprobanteDeVenta,2) );
			}
		}

		public string GetWarnings()
		{			
			//if( GenerariaPagoACuenta())
			  // return "El importe de la forma de pago es mayor al importe de la factura. Se va a generar un Pago a Cuenta.";
			//else 
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
		public void Continue()
		{
			_processParent.MostroWarnings = true;
			OnTaskAfterExecute(this, new EventArgs());
		}

		#endregion

		public void SetModified()
		{
			_modified = true;
		}

		#region Metodos Publicos
				
		public void AddRecargo(FormaDePago formaDePago)
		{
			_recargos.AddRecargo(formaDePago, this._totalConImpuestoComprobanteDeVenta);

			if(ObjectHasChanged != null)
				 ObjectHasChanged(this, new EventArgs());
				
		}

		public bool AllowShow()
		{
			return (_allowShowVariable || (Math.Abs(this.Saldo) > Convert.ToDecimal(0.05) && _formasDePagos.Count > 0))
				&& _allowShow //Que tiene formas de pagos asociadas a la condicion de venta
				&& _procesoCambiarMercaderiaVisualizaVentana;
		}
		public void FormHasClosed() 
		{
		}
	
		#endregion

		private void _recargos_ImporteAbonadoChanged(object sender, EventArgs e)
		{
			_modified = true;
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		private void _recargos_OnModified(object sender, EventArgs e)
		{
			_modified = true;
		}

		public bool Modified
		{
			get
			{
				return _modified;
			}
		}
		private Hashtable _reglasDeValidacion;
		public Hashtable ReglasDeValidacion
		{
			get { return _reglasDeValidacion ; }
		}


	}
}
