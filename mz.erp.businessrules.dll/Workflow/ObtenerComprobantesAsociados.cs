using System;
using System.Data;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ObtenerComprobantesAsociados.
	/// </summary>
	public class ObtenerComprobantesAsociados:ITask
	{
		public ObtenerComprobantesAsociados()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		#region Propiedades


		private RelacionesComprobanteOrigenDestino _relaciones;
		public RelacionesComprobanteOrigenDestino RelacionesComprobantes
		{
			get{return _relaciones;}
		}


		public Hashtable TableComprobantesHaciaAtrasAdelante 
		{
			get{return _tableComprobantesHaciaAtrasAdelante;}
		}

		public ArrayList ListaIdComprobantesHaciaAdelante
		{
			get{return _idComprobantesHaciaAdelante;}
		}
		public ArrayList ListaIdComprobantesHaciaAtras
		{
			get{return _idComprobantesHaciaAtras;}
		}

		public ArrayList ListaIdComprobantesHaciaAtrasAdelante
		{
			get{return _idComprobantesHaciaAtrasAdelante;}
		}

		public ArrayList ListaIdComprobantesHaciaAdelanteAtras
		{
			get{return _idComprobantesHaciaAdelanteAtras;}
		}
	
		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionItemsPendientes)))
			{
				SeleccionItemsPendientes sip  = (SeleccionItemsPendientes)sender;
				if(_processParent.Process.ProcessName.Equals("ProcesoVenderDevolver")
					|| _processParent.Process.ProcessName.Equals("ProcesoPrestarDevolver")
					|| _processParent.Process.ProcessName.Equals("ProcesoVenderDevolverManual")
					|| _processParent.Process.ProcessName.Equals("ProcesoVenderDevolverBienDeUso")
					)
					LoadFromSeleccionarItemsPendientesPorItem(sip);
				else
					LoadFromSeleccionarItemsPendientes(sip);
			}

			
		}

		private void LoadFromSeleccionarItemsPendientesPorItem(SeleccionItemsPendientes sip)
		{
			_relaciones = new RelacionesComprobanteOrigenDestino();
			_relaciones.IdCuenta = sip.RelacionesComprobanteOrigenDestino.IdCuenta;
			_relaciones.Observaciones = sip.RelacionesComprobanteOrigenDestino.Observaciones;
			foreach(RelacionComprobanteOrigenDestino crod in sip.RelacionesComprobanteOrigenDestino)
			{
				string IdTipoDeComprobanteOrigen = crod.IdTipoDeComprobante;
				string IdComprobante = crod.IdComprobante;
				long ordinal = crod.OrdinalOrigen;
				string TipoComprobanteDestino = string.Empty;
				if(_tableHaciaAdelante.ContainsKey(IdTipoDeComprobanteOrigen))
				{
					//German 20090520
					if(crod.CantidadDestino > 0)
					{
						//Fin German 20090520
						ArrayList TipoComprobanteDestinoList = (ArrayList) _tableHaciaAdelante[IdTipoDeComprobanteOrigen];
						TipoComprobanteDestino = mz.erp.systemframework.Util.PackString(TipoComprobanteDestinoList);
						DataSet data = Workflow.GetCaminoComprobantesOrdinalTopDown( IdComprobante, ordinal, TipoComprobanteDestino);
						decimal cantIntemerdios = 0;
						decimal cantFinales = 0;
						string IdComprobantePreparado = string.Empty;
						string IdTipoDeComprobantePreparado = string.Empty;
						long OrdinalPreparado = -1;
						foreach(DataRow row in data.Tables[0].Rows)
						{
							string ITDC = Convert.ToString(row["IdTipoDeComprobante"]);
							decimal cant = Convert.ToDecimal(row["Cantidad"]);
							long ord = Convert.ToInt64(row["Ordinal"]);
							if(_comprobantesIntermedios.Contains(ITDC))
							{
								IdComprobantePreparado = Convert.ToString(row["IdComprobante"]);
								IdTipoDeComprobantePreparado = ITDC;
								OrdinalPreparado = ord;
								cantIntemerdios = cant;
							}
							if(TipoComprobanteDestinoList.Contains(ITDC))
							
								cantFinales = cantFinales + cant;
						}
						//Se debe anular el comprobante de preparado pues no fue entregada
						if((cantIntemerdios - cantFinales) > 0)
						{
							RelacionComprobanteOrigenDestino rcod = new RelacionComprobanteOrigenDestino(
								IdComprobantePreparado,
								IdTipoDeComprobantePreparado,
								string.Empty,
								OrdinalPreparado,
								cantIntemerdios,
								crod.CantidadDestino,
								crod.IdProducto,
								crod.Descripcion,
								crod.Precio,
								crod.IdCondicionDeVenta,
								crod.PrecioNetoActual,
								string.Empty,
								string.Empty,
								string.Empty,
								crod.IdListaDePrecios,
								crod.CoeficienteListaDePrecios,
								crod.ModoDeAplicacionListaDePrecios,
								crod.IdListaDePreciosDefault);
							_relaciones.Add(rcod);

		
						}
					}
				//German 20090520
				}
				//Fin German 20090520
			}

		}


		private void LoadFromSeleccionarItemsPendientes(SeleccionItemsPendientes sip)
		{
				
			if(_analizarCaminosPorItem)
			{
				foreach(RelacionComprobanteOrigenDestino crod in sip.RelacionesComprobanteOrigenDestino)
				{
					string IdTipoDeComprobanteOrigen = crod.IdTipoDeComprobante;
					string IdComprobante = crod.IdComprobante;
					/*Falta Implementar este metodo*/
                    //ObtenerCaminos(IdComprobante, IdTipoDeComprobanteOrigen, crod.OrdinalOrigen);
				}
			}
			else
			{
				string IdTipoDeComprobanteOrigen = sip.RelacionesComprobanteOrigenDestino.Get(0).IdTipoDeComprobante;
				string IdComprobante = sip.RelacionesComprobanteOrigenDestino.Get(0).IdComprobante;
				ObtenerCaminos(IdComprobante, IdTipoDeComprobanteOrigen);

			}
		}

		private Hashtable _caminosHaciaAdelante = new Hashtable();
		private Hashtable _caminosHaciaAtras = new Hashtable();
		private Hashtable _caminosHaciaAtrasAdelante = new Hashtable();


		private ArrayList _idComprobantesHaciaAtras = new ArrayList();
		private ArrayList _idComprobantesHaciaAdelanteAtras = new ArrayList();
		private ArrayList _idComprobantesHaciaAtrasAdelante = new ArrayList();
		private ArrayList _idComprobantesHaciaAdelante = new ArrayList();

			private Hashtable _tableComprobantesHaciaAtrasAdelante = new Hashtable();


		private void ObtenerCaminos(string IdComprobante, string IdTipoDeComprobanteOrigen)
		{
			ArrayList caminosHaciaAdelante;
			ArrayList caminosHaciaAtras;
			ArrayList caminosHaciaAtrasAdelante;
			
			#region Caminos Hacia Adelante
			if(_tableHaciaAdelante.ContainsKey(IdTipoDeComprobanteOrigen) && !_caminosHaciaAdelante.ContainsKey(IdTipoDeComprobanteOrigen))
			{
				_idComprobantesHaciaAdelante.Clear();
				_caminosHaciaAdelante.Add(IdTipoDeComprobanteOrigen, new Hashtable());
				caminosHaciaAdelante = (ArrayList)_tableHaciaAdelante[IdTipoDeComprobanteOrigen];
				Hashtable _destinos = (Hashtable)_caminosHaciaAdelante[IdTipoDeComprobanteOrigen];
				foreach(string IdTipoDeComprobanteDestino in caminosHaciaAdelante)
				{
					if(! _destinos.ContainsKey(IdTipoDeComprobanteDestino))
					{
						DataSet data = Workflow.GetComprobantesTopDown(IdComprobante, IdTipoDeComprobanteDestino);
						ArrayList aux = new ArrayList();
						foreach(DataRow row in data.Tables[0].Rows)
						{
							aux.Add(Convert.ToString(row["IdComprobante"]));
							_idComprobantesHaciaAdelante.Add(Convert.ToString(row["IdComprobante"]));
						}
						_destinos.Add(IdTipoDeComprobanteDestino, aux);
					}
					
					
									
				}

			}
			#endregion

			#region Caminos Hacia Atras
			if(_tableHaciaAtras.ContainsKey(IdTipoDeComprobanteOrigen) && !_caminosHaciaAtras.ContainsKey(IdTipoDeComprobanteOrigen))
			{
				_idComprobantesHaciaAtras.Clear();
				caminosHaciaAtras = (ArrayList)_tableHaciaAtras[IdTipoDeComprobanteOrigen];
				_caminosHaciaAtras.Add(IdTipoDeComprobanteOrigen, new Hashtable());
				Hashtable _destinos = (Hashtable)_caminosHaciaAtras[IdTipoDeComprobanteOrigen];
				foreach(string IdTipoDeComprobanteDestino in caminosHaciaAtras)
				{
					if(!_destinos.ContainsKey(IdTipoDeComprobanteDestino))
					{
						DataSet data = Workflow.GetComprobantesBottonUp(IdComprobante, IdTipoDeComprobanteDestino);
						ArrayList aux = new ArrayList();
						foreach(DataRow row in data.Tables[0].Rows)
						{
							aux.Add(Convert.ToString(row["IdComprobante"]));
							_idComprobantesHaciaAtras.Add(Convert.ToString(row["IdComprobante"]));
						}
						_destinos.Add(IdTipoDeComprobanteDestino, aux);
					}
				}

			}
			#endregion

			#region Caminos Hacia Atras Adelante

			/*Se puede Mejorar Muchismo. Hacer una clase Resultado*/
			if(_tableHaciaAtrasAdelante.ContainsKey(IdTipoDeComprobanteOrigen))
			{
				_idComprobantesHaciaAtrasAdelante.Clear();
				Hashtable tableAtras = (Hashtable)_tableHaciaAtrasAdelante[IdTipoDeComprobanteOrigen];
				foreach(string IdTipoDeComprobantesAtras in tableAtras.Keys)
				{
					DataSet data = Workflow.GetComprobantesBottonUp(IdComprobante, IdTipoDeComprobantesAtras);
					ArrayList aux = new ArrayList();
					foreach(DataRow row in data.Tables[0].Rows)
					{
						aux.Add(Convert.ToString(row["IdComprobante"]));
					}
					foreach(string IdComprobanteAtras in aux)
					{
						ArrayList tiposDeComprobantesHaciaAdelante = (ArrayList)tableAtras[IdTipoDeComprobantesAtras];
						foreach(string IdTipoDeComprobanteAdelante in tiposDeComprobantesHaciaAdelante)
						{
							data = Workflow.GetComprobantesTopDown(IdComprobanteAtras, IdTipoDeComprobanteAdelante);
							foreach(DataRow row in data.Tables[0].Rows)
							{
								_idComprobantesHaciaAtrasAdelante.Add(Convert.ToString(row["IdComprobante"]));
								if(!_tableComprobantesHaciaAtrasAdelante.ContainsKey(Convert.ToString(row["IdTipoDeComprobante"])))
									_tableComprobantesHaciaAtrasAdelante.Add(Convert.ToString(row["IdTipoDeComprobante"]), Convert.ToString(row["IdComprobante"]));
							}
						}
					}
				}

			}

			#endregion

			
		}


		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.ListenerBeforeExecuteDependentTask
		}


		private string _listaComprobantesHaciaAdelante = string.Empty;
		private string _listaComprobantesHaciaAtras = string.Empty;
		private string _listaComprobantesHaciaAtrasAdelante = string.Empty;
		private string _listaComprobantesHaciaAdelanteAtras = string.Empty;

	

		public void Init()
		{
			_listaComprobantesHaciaAtras = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaCaminosHaciaAtras");
			_listaComprobantesHaciaAdelante = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaCaminosHaciaAdelante");
			_listaComprobantesHaciaAtrasAdelante = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaCaminosHaciaAtrasAdelante");
			_listaComprobantesHaciaAdelanteAtras = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaCaminosHaciaAdelanteAtras");
			string ComprobantesIntermedios = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaComprobantesIntermedios");
			_comprobantesIntermedios = mz.erp.systemframework.Util.Parse(ComprobantesIntermedios);
			BuildCaminos();
		}


		private ArrayList _comprobantesIntermedios = new ArrayList();
		private Hashtable _tableHaciaAdelante = new Hashtable();
		private Hashtable _tableHaciaAtras = new Hashtable();
		private Hashtable _tableHaciaAdelanteAtras = new Hashtable();
		private Hashtable _tableHaciaAtrasAdelante = new Hashtable();
		private bool _analizarCaminosPorItem = false;

		private void BuildCaminosHaciaAdelante()
		{
			string[] listaComprobantesHaciaAdelante = _listaComprobantesHaciaAdelante.Split( ';');
			if (listaComprobantesHaciaAdelante.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<listaComprobantesHaciaAdelante.Length;i++)
				{
					string[] atupla = listaComprobantesHaciaAdelante[i].Split(':');
					if (atupla.Length == 2)
					{
						if(!_tableHaciaAdelante.ContainsKey(atupla[0]))
							_tableHaciaAdelante.Add(atupla[0], new ArrayList());
						((ArrayList)_tableHaciaAdelante[atupla[0]]).Add(atupla[1]);
					}
				}
			}
		}

		private void BuildCaminosHaciaAtras()
		{

			string[] listaComprobantesHaciaAtras = _listaComprobantesHaciaAtras.Split( ';');
			if (listaComprobantesHaciaAtras.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<listaComprobantesHaciaAtras.Length;i++)
				{
					string[] atupla = listaComprobantesHaciaAtras[i].Split(':');
					if (atupla.Length == 2)
					{
						if(!_tableHaciaAtras.ContainsKey(atupla[0]))
							_tableHaciaAtras.Add(atupla[0], new ArrayList());
						((ArrayList)_tableHaciaAtras[atupla[0]]).Add(atupla[1]);
					}
				}
			}
			
		}

		private void BuildCaminosHaciaAdelanteAtras()
		{
			string[] listaComprobantesHaciaAdelanteAtras = _listaComprobantesHaciaAdelanteAtras.Split( ';');
			if (listaComprobantesHaciaAdelanteAtras.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<listaComprobantesHaciaAdelanteAtras.Length;i++)
				{
					string[] atupla = listaComprobantesHaciaAdelanteAtras[i].Split(':');
					if (atupla.Length == 3)
					{
						if(!_tableHaciaAdelanteAtras.ContainsKey(atupla[0]))
							_tableHaciaAdelanteAtras.Add(atupla[0], new Hashtable());
						Hashtable temp = (Hashtable)_tableHaciaAdelanteAtras[atupla[0]];
						if(!temp.ContainsKey(atupla[1]))
							temp.Add(atupla[1], new ArrayList());
						ArrayList aux = (ArrayList)temp[atupla[1]];
						if(!aux.Contains(atupla[2]))
							aux.Add(atupla[2]);
					}
				}
			}
		}

		private void BuildCaminosHaciaAtrasAdelante()
		{
			string[] listaComprobantesHaciaAtrasAdelante = _listaComprobantesHaciaAtrasAdelante.Split( ';');
			if (listaComprobantesHaciaAtrasAdelante.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<listaComprobantesHaciaAtrasAdelante.Length;i++)
				{
					string[] atupla = listaComprobantesHaciaAtrasAdelante[i].Split(':');
					if (atupla.Length == 3)
					{
						if(!_tableHaciaAtrasAdelante.ContainsKey(atupla[0]))
							_tableHaciaAtrasAdelante.Add(atupla[0], new Hashtable());
						Hashtable temp = (Hashtable)_tableHaciaAtrasAdelante[atupla[0]];
						if(!temp.ContainsKey(atupla[1]))
							temp.Add(atupla[1], new ArrayList());
						ArrayList aux = (ArrayList)temp[atupla[1]];
						if(!aux.Contains(atupla[2]))
							aux.Add(atupla[2]);
					}
				}
			}
		}

		
		private void BuildCaminos()
		{
			BuildCaminosHaciaAdelante();
			BuildCaminosHaciaAtras();
			BuildCaminosHaciaAdelanteAtras();
			BuildCaminosHaciaAtrasAdelante();
		}

		

		public bool IsValid()
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.IsValid
			return false;
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

		public bool AllowShow()
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.AllowShow
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
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.GetWarnings
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
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.AllowPrevious
			return false;
		}

		public void Previous()
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.Previous
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación GrabarMovimientoDeStockOR.ListenerBeforePreviousDependentTask
		}


		#endregion
	}
}

