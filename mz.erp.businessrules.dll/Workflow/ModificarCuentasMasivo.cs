using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.Collections;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ModificarCuentasMasivo.
	/// </summary>
	public class ModificarCuentasMasivo: ITask, IPersistentTask
	{
		#region Constructores
		public ModificarCuentasMasivo()
		{
		}
		#endregion

		#region Variables Privadas
		private CuentaView _cuenta;
		private ArrayList _cuentas = new ArrayList();
		private string _tipoEdicionObservacionesDefault = ModificarCuentasMasivo.CONCATENA;
		private string _tipoEdicionCampoAuxiliar1Default = ModificarCuentasMasivo.CONCATENA;
		private string _tipoEdicionCampoAuxiliar2Default = ModificarCuentasMasivo.CONCATENA;
		private string _tipoEdicionCampoAuxiliar3Default = ModificarCuentasMasivo.CONCATENA;
		private bool _huboCambios = false;
		private tsa_CuentasDataset _dataCuentas = new tsa_CuentasDataset();
		private CuentaView _cuentaAnterior;
		private ArrayList _cuentasAnteriores = new ArrayList();
		private bool _seleccionMultilpleAnterior = false;
		#endregion

		#region Eventos
		public event EventHandler CuentasCollectionChanged;
		#endregion

		#region Constantes
		public static string CONCATENA = "Concatena";
		public static string REEMPLAZA = "Reemplaza";
		#endregion
		
		#region Propiedades

		private string _textoBotonAnterior = "Anterior";
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

		private string _textoBotonSiguiente = "Siguiente";
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

		public ArrayList Items
		{
			get{return _cuentas;}
		}

		private bool _allowRemoveItems = false;
		public bool AllowRemoveItems
		{
			get{return _allowRemoveItems;}
		}

		private bool _allowSeleccionMultiple = false;
		public bool AllowSeleccionMultiple
		{
			get{return _allowSeleccionMultiple;}
			
		}

		private bool _seleccionMultilple = false;
		public bool SeleccionMultiple
		{
			get{return _seleccionMultilple;}
			set
			{
				_seleccionMultilple = value;
			}
		}

		public object SelectedItem
		{
			set
			{
				if(value != null)
				{
					CuentaView cuenta = (CuentaView) value;
					if(cuenta != _cuenta)
					{
						_cuenta = cuenta;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
								
			}
		}
		
		private string _etiquetaCampoAuxiliar1 = string.Empty;	
		public string EtiquetaCampoAuxiliar1
		{
			get{return _etiquetaCampoAuxiliar1;}
		}

		private string _etiquetaCampoAuxiliar2 = string.Empty;	
		public string EtiquetaCampoAuxiliar2
		{
			get{return _etiquetaCampoAuxiliar2;}
		}

		private string _etiquetaCampoAuxiliar3 = string.Empty;	
		public string EtiquetaCampoAuxiliar3
		{
			get{return _etiquetaCampoAuxiliar3;}
		}

		private bool _allowEditLimiteDeCredito = false;
		public bool AllowEditLimiteDeCredito
		{
			get{return _allowEditLimiteDeCredito;}
		}

		private bool _allowEditDiasLimiteDeCredito = false;
		public bool AllowEditDiasLimiteDeCredito
		{
			get{return _allowEditDiasLimiteDeCredito;}
		}

		private bool _allowEditObservaciones = false;
		public bool AllowEditObservaciones
		{
			get{return _allowEditObservaciones;}
		}

		private bool _allowEditCampoAuxiliar1 = false;
		public bool AllowEditCampoAuxiliar1
		{
			get{return _allowEditCampoAuxiliar1 && !this._etiquetaCampoAuxiliar1.Equals(string.Empty);}
		}
		
		private bool _allowEditCampoAuxiliar2 = false;
		public bool AllowEditCampoAuxiliar2
		{
			get{return _allowEditCampoAuxiliar2 && !this._etiquetaCampoAuxiliar2.Equals(string.Empty);}
		}

		private bool _allowEditCampoAuxiliar3 = false;
		public bool AllowEditCampoAuxiliar3
		{
			get{return _allowEditCampoAuxiliar3 && !this._etiquetaCampoAuxiliar3.Equals(string.Empty);}
		}
		
		private bool _allowEditListaDePrecios = false;
		public bool AllowEditListaDePrecios
		{
			get{return _allowEditListaDePrecios;}
		}

		private bool _allowEditActivo = false;
		public bool AllowEditActivo
		{
			get{return _allowEditActivo;}
		}
		
		private bool _reemplazaObservaciones = false;
		public bool ReemplazaObservaciones
		{
			get{return _reemplazaObservaciones;}
			set{_reemplazaObservaciones = value;}
		}

		private bool _reemplazaCampoAuxiliar1 = false;
		public bool ReemplazaCampoAuxiliar1
		{
			get{return _reemplazaCampoAuxiliar1;}
			set{_reemplazaCampoAuxiliar1 = value;}
		}

		private bool _reemplazaCampoAuxiliar2 = false;
		public bool ReemplazaCampoAuxiliar2
		{
			get{return _reemplazaCampoAuxiliar2;}
			set{_reemplazaCampoAuxiliar2 = value;}
		}

		private bool _reemplazaCampoAuxiliar3 = false;
		public bool ReemplazaCampoAuxiliar3
		{
			get{return _reemplazaCampoAuxiliar3;}
			set{_reemplazaCampoAuxiliar3 = value;}
		}

		public decimal LimiteDeCredito
		{
			get
			{
				if(_cuenta != null)
				{
					return _cuenta.LimiteDeCredito;
				}
				return 0;

			}
			set
			{
				if(!_seleccionMultilple)
				{
					if(_cuenta != null)
					{

						if(value != _cuenta.LimiteDeCredito)
						{
							_cuenta.LimiteDeCredito = value;
						
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
							_huboCambios = true;
						}
					}
				}
				else
				{
					foreach(CuentaView cuenta in _cuentas)
					{
						if(cuenta.Selected)
						{
							cuenta.LimiteDeCredito = value;
							_huboCambios = true;
						}
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			
			}
		}
		

		public decimal DiasLimiteDeCredito
		{
			get
			{
				if(_cuenta != null)
				{
					return _cuenta.DiasLimiteDeCredito;
				}
				return 0;

			}
			set
			{
				if(!_seleccionMultilple)
				{
					if(_cuenta != null)
					{
						if(value != _cuenta.DiasLimiteDeCredito)
						{
							_cuenta.DiasLimiteDeCredito = value;
						
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
							_huboCambios = true;
						}
					}
				}
				else
				{
					foreach(CuentaView cuenta in _cuentas)
					{
						if(cuenta.Selected)
						{
							cuenta.DiasLimiteDeCredito = value;
							_huboCambios = true;
						}
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}				
			
		}
		
		public string Observaciones
		{
			get
			{
				if(_cuenta != null)
				{
					return _cuenta.Observaciones;
				}
				return string.Empty;

			}
			set
			{
				if(!_seleccionMultilple)
				{
					if(_cuenta != null)
					{
						if(value != _cuenta.Observaciones)
						{
							if(ReemplazaObservaciones)
								_cuenta.Observaciones = value;
							else
								_cuenta.Observaciones = _cuenta.Observaciones + value;
						
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
							_huboCambios = true;
						}
					}
				}
				else
				{
					foreach(CuentaView cuenta in _cuentas)
					{
						if(cuenta.Selected)
						{
							if(ReemplazaObservaciones)
								cuenta.Observaciones = value;
							else
								cuenta.Observaciones = cuenta.Observaciones + value;
							_huboCambios = true;
						}
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}			
				
			}
		}
		
		public string CampoAuxiliar1
		{
			get
			{
				if(_cuenta != null)
				{
					return _cuenta.CampoAuxiliar1;
				}
				return string.Empty;

			}
			set
			{
				if(!_seleccionMultilple)
				{
					if(_cuenta != null)
					{

						if(value != _cuenta.CampoAuxiliar1)
						{
							if(ReemplazaCampoAuxiliar1)
								_cuenta.CampoAuxiliar1 = value;
							else
								_cuenta.CampoAuxiliar1 = _cuenta.CampoAuxiliar1 + value;
						
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
							_huboCambios = true;
						}
					}
				}
				else
				{
					foreach(CuentaView cuenta in _cuentas)
					{
						if(cuenta.Selected)
						{
							if(ReemplazaCampoAuxiliar1)
								cuenta.CampoAuxiliar1 = value;
							else
								cuenta.CampoAuxiliar1 = cuenta.CampoAuxiliar1 + value;
							_huboCambios = true;
						}
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}


		public string CampoAuxiliar2
		{
			get
			{
				if(_cuenta != null)
				{
					return _cuenta.CampoAuxiliar2;
				}
				return string.Empty;

			}
			set
			{
				if(!_seleccionMultilple)
				{
					if(_cuenta != null)
					{
						if(value != _cuenta.CampoAuxiliar2)
						{
							if(ReemplazaCampoAuxiliar2)
								_cuenta.CampoAuxiliar2 = value;
							else
								_cuenta.CampoAuxiliar2 = _cuenta.CampoAuxiliar2 + value;
						
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
							_huboCambios = true;
						}
					}
				}
				else
				{
					foreach(CuentaView cuenta in _cuentas)
					{
						if(cuenta.Selected)
						{
							if(ReemplazaCampoAuxiliar2)
								cuenta.CampoAuxiliar2 = value;
							else
								cuenta.CampoAuxiliar2 = cuenta.CampoAuxiliar2 + value;
							_huboCambios = true;
						}
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}


		public string CampoAuxiliar3
		{
			get
			{
				if(_cuenta != null)
				{
					return _cuenta.CampoAuxiliar3;
				}
				return string.Empty;

			}
			set
			{
				if(!_seleccionMultilple)
				{
					if(_cuenta != null)
					{
						if(value != _cuenta.CampoAuxiliar3)
						{
							if(ReemplazaCampoAuxiliar3)
								_cuenta.CampoAuxiliar3 = value;
							else
								_cuenta.CampoAuxiliar3 = _cuenta.CampoAuxiliar3 + value;
						
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
							_huboCambios = true;
						}
					}
				}
				else
				{
					foreach(CuentaView cuenta in _cuentas)
					{
						if(cuenta.Selected)
						{
							if(ReemplazaCampoAuxiliar3)
								cuenta.CampoAuxiliar3 = value;
							else
								cuenta.CampoAuxiliar3 = cuenta.CampoAuxiliar3 + value;
							_huboCambios = true;
						}
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}


		public string IdListaDePreciosDefault
		{
			get
			{
				if(_cuenta != null)
				{
					return _cuenta.IdListaDePreciosDefault;
				}
                /* Silvina 20100921 - Tarea 841 */
                //return string.Empty;
                return Variables.GetValueString("Productos.IdListaDePreciosDefault", string.Empty);
                /* Fin Silvina */

			}
			set
			{
				if(!_seleccionMultilple)
				{
					if(_cuenta != null)
					{
						if(value != _cuenta.IdListaDePreciosDefault)
						{
							_cuenta.IdListaDePreciosDefault = value;
						
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
							_huboCambios = true;
						}
					}
				}
				else
				{
					foreach(CuentaView cuenta in _cuentas)
					{
						if(cuenta.Selected)
						{
							cuenta.IdListaDePreciosDefault = value;
							_huboCambios = true;
						}
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}


		public bool Activo
		{
			get
			{
				if(_cuenta != null)
				{
					return _cuenta.Activo;
				}
				return false;

			}
			set
			{
				if(!_seleccionMultilple)
				{
					if(_cuenta != null)
					{
						if(value != _cuenta.Activo)
						{
							_cuenta.Activo = value;
						
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
							_huboCambios = true;
						}
					}
				}
				else
				{
					foreach(CuentaView cuenta in _cuentas)
					{
						if(cuenta.Selected)
						{
							cuenta.Activo = value;
							_huboCambios = true;
						}
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}

		private bool _porCuenta = true;
		public bool PorCuenta
		{
			set
			{
				if(_porCuenta != value)
				{
					_porCuenta = value;
					if(!_porCuenta)
					{
						_cuentaAnterior = _cuenta;
						_cuentasAnteriores = new ArrayList();
						_cuentasAnteriores.AddRange(_cuentas);
						_seleccionMultilpleAnterior = _seleccionMultilple;
						_cuentas.Clear();
						_seleccionMultilple = false;
						SelectedItem = new CuentaView();
					}
					else
					{
						_cuentas = new ArrayList();
						_cuentas.AddRange(_cuentasAnteriores);
						_seleccionMultilple = _seleccionMultilpleAnterior;
						if(!SeleccionMultiple)
                            SelectedItem = _cuentaAnterior;
					}
				}
			}

		}

		private ArrayList _jerarquias1 = new ArrayList();
		public ArrayList  Jerarquias1
		{
			get{return _jerarquias1;}
			set{_jerarquias1 = value;}
		}

		private ArrayList _jerarquias2 = new ArrayList();
		public ArrayList  Jerarquias2
		{
			get{return _jerarquias2;}
			set{_jerarquias2 = value;}
		}

		private ArrayList _jerarquias3 = new ArrayList();
		public ArrayList  Jerarquias3
		{
			get{return _jerarquias3;}
			set{_jerarquias3 = value;}
		}

		private ArrayList _jerarquias4 = new ArrayList();
		public ArrayList  Jerarquias4
		{
			get{return _jerarquias4;}
			set{_jerarquias4 = value;}
		}

		private ArrayList _jerarquias5 = new ArrayList();
		public ArrayList  Jerarquias5
		{
			get{return _jerarquias5;}
			set{_jerarquias5 = value;}
		}

		private ArrayList _jerarquias6 = new ArrayList();
		public ArrayList  Jerarquias6
		{
			get{return _jerarquias6;}
			set{_jerarquias6 = value;}
		}

		private ArrayList _jerarquias7 = new ArrayList();
		public ArrayList  Jerarquias7
		{
			get{return _jerarquias7;}
			set{_jerarquias7 = value;}
		}

		private ArrayList _jerarquias8 = new ArrayList();
		public ArrayList  Jerarquias8
		{
			get{return _jerarquias8;}
			set{_jerarquias8 = value;}
		}

		private bool _byJerarquia1 = false;
		public bool ByJerarquia1
		{
			get{return _byJerarquia1;}
			set{_byJerarquia1 = value;}
		}

		private bool _byJerarquia2 = false;
		public bool ByJerarquia2
		{
			get{return _byJerarquia2;}
			set{_byJerarquia2 = value;}
		}

		private bool _byJerarquia3 = false;
		public bool ByJerarquia3
		{
			get{return _byJerarquia3;}
			set{_byJerarquia3 = value;}
		}

		private bool _byJerarquia4 = false;
		public bool ByJerarquia4
		{
			get{return _byJerarquia4;}
			set{_byJerarquia4 = value;}
		}

		private bool _byJerarquia5 = false;
		public bool ByJerarquia5
		{
			get{return _byJerarquia5;}
			set{_byJerarquia5 = value;}
		}

		private bool _byJerarquia6 = false;
		public bool ByJerarquia6
		{
			get{return _byJerarquia6;}
			set{_byJerarquia6 = value;}
		}

		private bool _byJerarquia7 = false;
		public bool ByJerarquia7
		{
			get{return _byJerarquia7;}
			set{_byJerarquia7 = value;}
		}

		private bool _byJerarquia8 = false;
		public bool ByJerarquia8
		{
			get{return _byJerarquia8;}
			set{_byJerarquia8 = value;}
		}

		private bool _modificaLimiteDeCredito = false;
		public bool ModificaLimiteDeCredito
		{
			get{return _modificaLimiteDeCredito;}
			set{_modificaLimiteDeCredito = value;}
		}

		private bool _modificaDiasLimiteDeCredito = false;
		public bool ModificaDiasLimiteDeCredito
		{
			get{return _modificaDiasLimiteDeCredito;}
			set{_modificaDiasLimiteDeCredito = value;}
		}

		private bool _modificaObservaciones = false;
		public bool ModificaObservaciones
		{
			get{return _modificaObservaciones;}
			set{_modificaObservaciones = value;}
		}

		private bool _modificaCampoAuxiliar1 = false;
		public bool ModificaCampoAuxiliar1
		{
			get{return _modificaCampoAuxiliar1;}
			set{_modificaCampoAuxiliar1 = value;}
		}
		
		private bool _modificaCampoAuxiliar2 = false;
		public bool ModificaCampoAuxiliar2
		{
			get{return _modificaCampoAuxiliar2;}
			set{_modificaCampoAuxiliar2 = value;}
		}

		private bool _modificaCampoAuxiliar3 = false;
		public bool ModificaCampoAuxiliar3
		{
			get{return _modificaCampoAuxiliar3;}
			set{_modificaCampoAuxiliar3 = value;}
		}
		
		private bool _modificaListaDePrecios = false;
		public bool ModificaListaDePrecios
		{
			get{return _modificaListaDePrecios;}
			set{_modificaListaDePrecios = value;}
		}

		private bool _modificaActivo = false;
		public bool ModificaActivo
		{
			get{return _modificaActivo;}
			set{_modificaActivo = value;}
		}
		
		#endregion
		
		#region Metodos Privados
		private bool ExisteCuenta(ArrayList cuentas, string IdCuenta)
		{
			bool resultado = false;
			foreach(CuentaView cuenta in cuentas) 
			{
				if (cuenta.IdCuenta.Equals(IdCuenta))
				{
					return true;
				}
			}			
			return resultado;
		}
		
		private string BuildJerarquia(ArrayList je)
		{
			string jerarquias = "";
			ArrayList array = new ArrayList();
			if(je.Count > 0)
			{
				foreach (object item in je)
				{
					ItemJerarquia it = (ItemJerarquia) item;
					array.Add(it.NodeKeyPath);
				}				
				jerarquias = systemframework.Util.PackString(array);
				
			}
			return jerarquias;
		}
		
		private ArrayList getCuentasSeleccionadas()
		{
			ArrayList cuentasModificadas = new ArrayList();
			foreach(CuentaView cuenta in _cuentas)
			{
				if(cuenta.Selected)
					cuentasModificadas.Add(cuenta);

			}
			if(cuentasModificadas.Count == 0)
				cuentasModificadas.Add(this._cuenta);
			return cuentasModificadas;
		}
		#endregion

		#region Miembros de ITask

		private string _taskName = string.Empty;			
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

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
			_etiquetaCampoAuxiliar1 = Variables.GetValueString("Cuentas.CampoAuxiliar1.Etiqueta");
			_etiquetaCampoAuxiliar1 = _etiquetaCampoAuxiliar1.Equals(string.Empty)?"CampoAuxiliar1":_etiquetaCampoAuxiliar1;
			_etiquetaCampoAuxiliar2 = Variables.GetValueString("Cuentas.CampoAuxiliar2.Etiqueta");
			_etiquetaCampoAuxiliar2 = _etiquetaCampoAuxiliar2.Equals(string.Empty)?"CampoAuxiliar2":_etiquetaCampoAuxiliar2;
			_etiquetaCampoAuxiliar3 = Variables.GetValueString("Cuentas.CampoAuxiliar3.Etiqueta");
			_etiquetaCampoAuxiliar3 = _etiquetaCampoAuxiliar3.Equals(string.Empty)?"CampoAuxiliar3":_etiquetaCampoAuxiliar3;
			
			_allowRemoveItems = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"AllowRemoveItems", _allowRemoveItems);
			_allowSeleccionMultiple = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"AllowMultipleSelect", _allowSeleccionMultiple);
			_allowEditLimiteDeCredito = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"Editar.LimiteDeCredito", _allowEditLimiteDeCredito);
			_allowEditDiasLimiteDeCredito = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"Editar.DiasLimiteDeCredito", _allowEditDiasLimiteDeCredito);
			_allowEditObservaciones = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"Editar.Observaciones", _allowEditObservaciones);
			_allowEditCampoAuxiliar1 = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"Editar.CampoAuxiliar1", _allowEditCampoAuxiliar1);
			_allowEditCampoAuxiliar2 = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"Editar.CampoAuxiliar2", _allowEditCampoAuxiliar2);
			_allowEditCampoAuxiliar3 = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"Editar.CampoAuxiliar3", _allowEditCampoAuxiliar3);
			_allowEditListaDePrecios = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"Editar.ListaDePrecios", _allowEditListaDePrecios);
			_allowEditActivo = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"Editar.Activo", _allowEditActivo);

			_tipoEdicionObservacionesDefault = Variables.GetValueStringDefault(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"TipoEdicion.Observaciones.Default", _tipoEdicionObservacionesDefault);
			_tipoEdicionCampoAuxiliar1Default = Variables.GetValueStringDefault(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"TipoEdicion.CampoAuxiliar1.Default", _tipoEdicionCampoAuxiliar1Default);
			_tipoEdicionCampoAuxiliar2Default = Variables.GetValueStringDefault(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"TipoEdicion.CampoAuxiliar2.Default", _tipoEdicionCampoAuxiliar2Default);
			_tipoEdicionCampoAuxiliar3Default = Variables.GetValueStringDefault(this.GetProcessManagerParent().Process.ProcessName,this.GetTaskName(),"TipoEdicion.CampoAuxiliar3.Default", _tipoEdicionCampoAuxiliar3Default);

			_reemplazaObservaciones = _tipoEdicionObservacionesDefault.Equals( ModificarCuentasMasivo.REEMPLAZA);
			_reemplazaCampoAuxiliar1 = _tipoEdicionCampoAuxiliar1Default.Equals( ModificarCuentasMasivo.REEMPLAZA);
			_reemplazaCampoAuxiliar2 = _tipoEdicionCampoAuxiliar2Default.Equals( ModificarCuentasMasivo.REEMPLAZA);
			_reemplazaCampoAuxiliar3 = _tipoEdicionCampoAuxiliar3Default.Equals( ModificarCuentasMasivo.REEMPLAZA);

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
			_errores.Clear();
			bool isvalid = true;
			return isvalid;
		}


		public bool AllowShow()
		{
			return Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "MuestraFormulario", true);
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
			string warning = string.Empty;
			if(_huboCambios)
			{
				ArrayList cuentasModificadas = this.getCuentasSeleccionadas();
				if(cuentasModificadas.Count > 1)
				{
					warning = "¿Confirma que desea aplicar las modificaciones a las sigueintes cuentas: ";
					int i = 1;
					foreach(CuentaView cuenta in cuentasModificadas)
					{
						warning = warning + cuenta.Codigo;
						i++;
						if(i < cuentasModificadas.Count)
							warning = warning + ", ";
						else if(i == cuentasModificadas.Count)
							warning = warning + " y ";						
					}
					warning = warning + "?";
				}
				else
				{
					warning = "¿Confirma que desea aplicar las modificaciones?";
				}
			}
			return warning;
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
			return this._taskName;
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

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			return data;
		}

		public void Commit()
		{
			if(_porCuenta)
			{
				foreach(CuentaView cuenta in this._cuentas)
				{
					tsa_CuentasDataset.tsa_CuentasRow row = tsa_Cuentas.GetByPk(cuenta.IdCuenta);
					_dataCuentas.tsa_Cuentas.ImportRow(row);
					tsa_CuentasDataset.tsa_CuentasRow rowCuenta =_dataCuentas.tsa_Cuentas.FindByIdCuenta(cuenta.IdCuenta);
					rowCuenta.LimiteDeCredito = cuenta.LimiteDeCredito;
					rowCuenta.DiasLimiteDeCredito = cuenta.DiasLimiteDeCredito;
					rowCuenta.Observaciones = cuenta.Observaciones;
					rowCuenta.CampoAuxiliar1 = cuenta.CampoAuxiliar1;
					rowCuenta.CampoAuxiliar2 = cuenta.CampoAuxiliar2;
					rowCuenta.CampoAuxiliar3 = cuenta.CampoAuxiliar3;
					rowCuenta.Activo = cuenta.Activo;
					rowCuenta.IdListaDePreciosDefault = cuenta.IdListaDePreciosDefault;

				}
			}
			else
			{
				string j1 = BuildJerarquia(_jerarquias1);
				string j2 = BuildJerarquia(_jerarquias2);
				string j3 = BuildJerarquia(_jerarquias3);
				string j4 = BuildJerarquia(_jerarquias4);
				string j5 = BuildJerarquia(_jerarquias5);
				string j6 = BuildJerarquia(_jerarquias6);
				string j7 = BuildJerarquia(_jerarquias7);
				string j8 = BuildJerarquia(_jerarquias8);

				bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
				string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
				string[] jers = new string[8]{string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty};
				for(int i = 0; i<8;i++)
				{
					if(aux[i])
					{
						for(int j = 0; j<8; j++)
						{
							if(jers[j] == string.Empty)
							{
								jers[j] = jerarquias[i];
								break;
							}
						}
					}
				}
			
				j1 = jers[0];
				j2 = jers[1];
				j3 = jers[2];
				j4 = jers[3];
				j5 = jers[4];
				j6 = jers[5];
				j7 = jers[6];
				j8 = jers[7];	

				tsa_CuentasDataset data = tsa_Cuentas.SearchCuentasByJerarquia(j1,j2,j3,j4,j5,j6,j7,j8, Security.IdEmpresa, Security.IdSucursal);			
				_dataCuentas = data;
				foreach(tsa_CuentasDataset.tsa_CuentasRow rowCuenta in _dataCuentas.tsa_Cuentas.Rows)
				{
					if(ModificaLimiteDeCredito)
                        rowCuenta.LimiteDeCredito = _cuenta.LimiteDeCredito;
					if(ModificaDiasLimiteDeCredito)
                        rowCuenta.DiasLimiteDeCredito = _cuenta.DiasLimiteDeCredito;
					if(ModificaObservaciones)
					{
						if(ReemplazaObservaciones)
                            rowCuenta.Observaciones = _cuenta.Observaciones;
						else
							rowCuenta.Observaciones = rowCuenta.Observaciones + _cuenta.Observaciones;
					}
					if(ModificaCampoAuxiliar1)
					{
						if(ReemplazaCampoAuxiliar1)
							rowCuenta.CampoAuxiliar1 = _cuenta.CampoAuxiliar1;
						else
							rowCuenta.CampoAuxiliar1 = rowCuenta.CampoAuxiliar1 + _cuenta.CampoAuxiliar1;
					}
					if(ModificaCampoAuxiliar2)
					{
						if(ReemplazaCampoAuxiliar2)
							rowCuenta.CampoAuxiliar2 = _cuenta.CampoAuxiliar2;
						else
							rowCuenta.CampoAuxiliar2 = rowCuenta.CampoAuxiliar2 + _cuenta.CampoAuxiliar2;
					}
					if(ModificaCampoAuxiliar3)
					{
						if(ReemplazaCampoAuxiliar3)
							rowCuenta.CampoAuxiliar3 = _cuenta.CampoAuxiliar3;
						else
							rowCuenta.CampoAuxiliar3 = rowCuenta.CampoAuxiliar3 + _cuenta.CampoAuxiliar3;
					}
					if(ModificaActivo)
						rowCuenta.Activo = _cuenta.Activo;
					if(ModificaListaDePrecios)
                        rowCuenta.IdListaDePreciosDefault = _cuenta.IdListaDePreciosDefault;
				}
			}
			
		}


		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			SentenciasReplicacion _replicacion = GenerateReplicaction();
			mz.erp.dataaccess.tsa_Cuentas.Update(_dataCuentas.tsa_Cuentas, IdTransaction, _replicacion);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());	

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			
			return GenerateReplicaction();
		}

		private static SentenciasReplicacion  GenerateReplicaction()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_Cuentas";
			return replication;
			
		}

		public bool GetHasSaved()
		{
			
			return false;
		}

		#endregion

		#region Metodos Publicos

		public void AddCuenta(string IdCuenta)
		{
			if(!this.ExisteCuenta(_cuentas, IdCuenta))
			{
				CuentaView cuenta = new CuentaView(IdCuenta);
				this._cuentas.Add(cuenta);
			}
			if(CuentasCollectionChanged != null)
				CuentasCollectionChanged(this, new EventArgs());
		
		}

		public void Seleccionar(bool seleccionar)
		{
			foreach(CuentaView cuenta in _cuentas)
			{
				cuenta.Selected = seleccionar;
			}

		}

		public void AddRange(ArrayList rows)
		{
			foreach(System.Data.DataRow row in rows)
			{
				string IdCuenta = Convert.ToString(row["IdCuenta"]);
				if(!this.ExisteCuenta(_cuentas, IdCuenta))
				{
					CuentaView cuenta = new CuentaView(IdCuenta);
					this._cuentas.Add(cuenta);
				}
			}
			if(CuentasCollectionChanged != null)
				CuentasCollectionChanged(this, new EventArgs());
		}

		#endregion

		public sealed  class CuentaView
		{
		
			#region Constructores
			public CuentaView(string IdCuenta)
			{
				tsa_CuentasDataset.tsa_CuentasRow row = mz.erp.businessrules.tsa_Cuentas.GetByPk(IdCuenta);
				if(row != null)
				{
					CargarDatosPrincipales(row);
				}

			}

			public CuentaView()
			{
			}
			#endregion

			#region Variables Privadas

			private string _codigo = string.Empty;
			private string _idCuenta = string.Empty;
			private string _nombre = string.Empty;
			private decimal _limiteDeCredito = 0;
			private decimal _diasLimiteDeCredito = 0;
			private string _observaciones = string.Empty;
			private bool _activo = false;
			private string _campoAuxiliar1 = string.Empty;
			private string _campoAuxiliar2 = string.Empty;
			private string _campoAuxiliar3 = string.Empty;
			private string _idListaDePreciosDefault = string.Empty;
			private bool _selected = false;

			#endregion
		
			#region Propiedades

			public string IdCuenta
			{
				get
				{
					return _idCuenta;
				}
				set
				{
					_idCuenta = value;
				}
			}

			public string Codigo
			{
				get
				{
					return _codigo;
				}
				set
				{
					_codigo = value;
				}
			}
			public string Nombre
			{
				get
				{
					return _nombre;
				}
				set
				{
					_nombre = value;
				}
			}

			public decimal LimiteDeCredito
			{
				get
				{
					return _limiteDeCredito;
				}
				set
				{
					_limiteDeCredito = value;
				}
			}

			public decimal DiasLimiteDeCredito
			{
				get
				{
					return _diasLimiteDeCredito;
				}
				set
				{
					_diasLimiteDeCredito = value;
				}
			}
			
			public string Observaciones
			{
				get
				{
					return _observaciones;
				}
				set
				{
					_observaciones = value;
				}
			}

			public bool Activo
			{
				get
				{
					return _activo;
				}
				set
				{
					_activo = value;
				}
			}

			public string CampoAuxiliar1
			{
				get
				{
					return _campoAuxiliar1;
				}
				set
				{
					_campoAuxiliar1 = value;
				}
			}

			public string CampoAuxiliar2
			{
				get
				{
					return _campoAuxiliar2;
				}
				set
				{
					_campoAuxiliar2 = value;
				}
			}
			public string CampoAuxiliar3
			{
				get
				{
					return _campoAuxiliar3;
				}
				set
				{
					_campoAuxiliar3 = value;
				}
			}

			public string IdListaDePreciosDefault
			{
				get
				{
                    /* Silvina 20100921 - Tarea 841 */
                    if (_idListaDePreciosDefault.Equals(string.Empty))
                        return Variables.GetValueString("Productos.IdListaDePreciosDefault", string.Empty);
                    /* Fin Silvina */
					return _idListaDePreciosDefault;
				}
				set
				{
					_idListaDePreciosDefault = value;
				}
			}

			public bool Selected
			{
				get{return _selected;}
				set{_selected = value;}
			}
			
			#endregion

			#region Metodos Privados
			private void CargarDatosPrincipales(tsa_CuentasDataset.tsa_CuentasRow row)
			{
				_idCuenta = row.IdCuenta;
				_codigo = row.Codigo;
				_nombre = row.Nombre;
				_limiteDeCredito = row.LimiteDeCredito;
				_diasLimiteDeCredito = row.DiasLimiteDeCredito;
				_observaciones = row.Observaciones;
				_activo = row.Activo;
				_campoAuxiliar1 = row.CampoAuxiliar1;
				_campoAuxiliar2 = row.CampoAuxiliar2;
				_campoAuxiliar3 = row.CampoAuxiliar3;
				_idListaDePreciosDefault = row.IdListaDePreciosDefault;

			}

			#endregion
	
		}


	}
}
