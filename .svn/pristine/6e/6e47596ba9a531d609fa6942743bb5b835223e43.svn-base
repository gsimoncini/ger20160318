using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;	
using System.Collections;
using System.Text;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ComprobanteDeCompraCabecera.
	/// </summary>
	public class IngresarComprobanteDeCompraCabecera: ITask, IPersistentTask
	{
		public IngresarComprobanteDeCompraCabecera()
		{
			_comprobante = new ComprobanteDeCompraCabecera();		
		}
		#region Eventos				
		public event EventHandler TipoDeComprobanteDestinoChanged;
		public event EventHandler IdCuentaImputacionChanged;
		public event EventHandler IdCuentaImputacionProveedorChanged;//Utilizo este evento cuando la cuenta de imputación se modifica al cambiar el proveedor y para que sea distinto de cuando el cambio de la cuenta de imputación modifica las subcuentas de imputación.
		public event EventHandler IdSubCuentaImputacionProveedorChanged;
		public event EventHandler NetoChanged;
		public event EventHandler TotalChanged;

		public event EventHandler DiasVencimientoChanged;
		public event EventHandler FechaVencimientoChanged;
        //German 20120510 - Tarea 0000320
        public event EventHandler ProximaFechaVencimientoChanged;
        //Fin German 20120510 - Tarea 0000320
	
		public event EventHandler IdMonedaOrigenChanged;
		public event EventHandler TotalUsuarioChanged;
		public event EventHandler NetoItemsOriginalChanged;
		public event EventHandler CondicionDeCompraChanged;

		public event EventHandler NetosCollectionChanged;

		
		#endregion
		#region Variables Privadas

			
		private bool _isValid = false;		
		private ProcessManager _processParent;		
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();				
		private Proveedor _proveedor;		
		private string  _listaTiposDeComprobantesValidos;
		private ComprobanteDeCompraCabecera _comprobante;
		private bool _cambioNumero = false;
		private bool _allowShow = true;

		
		#endregion		
		#region Propiedades ITASK
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
		private string _textoCampoAuxiliar1 = "Campo Auxiliar 1";
		public string TextoCampoAuxiliar1
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar1." + "Etiqueta";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _textoCampoAuxiliar1;
				}
				else 
				{
					return valor;
				}
			}
		}
		private string _textoCampoAuxiliar2 = "Campo Auxiliar 2";
		public string TextoCampoAuxiliar2
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar2." + "Etiqueta";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _textoCampoAuxiliar2;
				}
				else 
				{
					return valor;
				}
			}
		}
		private string _textoCampoAuxiliar3 = "Campo Auxiliar 3";
		public string TextoCampoAuxiliar3
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar3." + "Etiqueta";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _textoCampoAuxiliar3;
				}
				else 
				{
					return valor;
				}
			}
		}
		private string _textoCampoAuxiliar4 = "Campo Auxiliar 4";
		public string TextoCampoAuxiliar4
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar4." + "Etiqueta";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _textoCampoAuxiliar4;
				}
				else 
				{
					return valor;
				}
			}
		}

		private string _mascaraCampoAuxiliar1 = "\\A-####-########";
		public string MascaraCampoAuxiliar1
		{
			get 
			{		
				string valor = String.Empty;								
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + ".CampoAuxiliar1." + "Mascara";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _mascaraCampoAuxiliar1;
				}
				else 
				{
					return valor;
				}
			}
		}

        //German 20110309 - Tarea 0000038
        private RelacionesComprobanteDeCompraOrigenDestino _relacionesComprobantesDeCompraOrigenDestino;
        //Fin German 20110309 - Tarea 0000038

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
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof( mz.erp.businessrules.IngresarPrecioProducto ))
			{
				IngresarPrecioProducto task = (IngresarPrecioProducto)sender;
				UpdateFromIngresarPrecioProducto(task);
			}
			/*
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra)) 
				&& sender != this && this._taskName.Equals("IngresarComprobanteDeCompraCabecera"))
			{
				ComprobanteDeCompra c = (ComprobanteDeCompra) sender;
				UpdateFromComprobanteDeCompra(c);
			}
			*/

            //German 20110309 - Tarea 0000038
            if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra))
            {
                ComprobanteDeCompra task = (ComprobanteDeCompra)sender;
                if (task.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoIngresarComprasCompleto")
                    && task.GetTaskName().Equals("ConfirmarIngresoMercaderia")
                   
                    )
                {
                    //GetRelacionesComprobantesOrigenDestino(task);
                    if (task.RelacionesComprobanteDeCompraOrigenDestino != null && task.RelacionesComprobanteDeCompraOrigenDestino.Count > 0)
                    {
                        Step(task.RelacionesComprobanteDeCompraOrigenDestino);
                        //German 20120615 - Tarea 0000355
                        _comprobante.ProximaFechaVencimiento = _comprobante.FechaVencimiento;
                        //Fin German 20120615 - Tarea 0000355
                    }
                    /*
                    if (ObjectHasChanged != null)
                            ObjectHasChanged(this, new EventArgs());
                    */

                }
            }
            //Fin German 20110309 - Tarea 0000038
            
            if (sender.GetType() == typeof( mz.erp.businessrules.SeleccionItemsDeCompraPendientes )
				&& !_processParent.Process.ProcessName.Equals("ProcesoCompletarFacturaCompras"))
			{
				SeleccionItemsDeCompraPendientes itemsPendientes = (SeleccionItemsDeCompraPendientes)sender;
				if(itemsPendientes.RelacionesComprobanteDeCompraOrigenDestino!= null && itemsPendientes.RelacionesComprobanteDeCompraOrigenDestino.Count > 0)
				{
					Step( ((SeleccionItemsDeCompraPendientes)sender).RelacionesComprobanteDeCompraOrigenDestino);
                    //German 20120809 - Tarea 0000369
                    _comprobante.ProximaFechaVencimiento = _comprobante.FechaVencimiento;
                    //Fin German 20120809 - Tarea 0000369
				}
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}		
			if (sender.GetType() == typeof( mz.erp.businessrules.SeleccionItemsDeCompraPendientes )
				&& _processParent.Process.ProcessName.Equals("ProcesoCompletarFacturaCompras"))
			{
				SeleccionItemsDeCompraPendientes itemsPendientes = (SeleccionItemsDeCompraPendientes)sender;
				if(itemsPendientes.RelacionesComprobanteDeCompraOrigenDestino!= null && itemsPendientes.RelacionesComprobanteDeCompraOrigenDestino.Count > 0)
				{
					StepEdit( ((SeleccionItemsDeCompraPendientes)sender).RelacionesComprobanteDeCompraOrigenDestino);
				}
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}	
			if (sender.GetType() == typeof( mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes )
				&& (( _processParent.Process.ProcessName.Equals("ProcesoEditarComprobanteServicios")) || ( _processParent.Process.ProcessName.Equals("ProcesoEditarComprobantesFacturasCompras"))))
			{
				SeleccionarComprobantesDeCompraPendientes task = (SeleccionarComprobantesDeCompraPendientes)sender;
				if(task.ArrayComprobantesPendientes != null && task.ArrayComprobantesPendientes.Count > 0)
				{
					Edit( (string)task.ArrayComprobantesPendientes[0]);
				}
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}	
		}

        //German 20110309 - Tarea 0000038
        private void GetRelacionesComprobantesOrigenDestino(ComprobanteDeCompra compPrevio)
        {
            _relacionesComprobantesDeCompraOrigenDestino = new RelacionesComprobanteDeCompraOrigenDestino(compPrevio);
        }
        //Fin German 20110309 - Tarea 0000038

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			InitData();
			InitEventHandlers();
			SetEditablesProperty();
		}

		private void InitData()
		{			
			_comprobante.Init();			
			_comprobante.IdResponsable = Security.IdPersona;
			_comprobante.FechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
			_comprobante.FechaRegistracion = mz.erp.businessrules.Sistema.DateTime.Now;
			this._tableMonedas = mz.erp.businessrules.tfi_Monedas.GetList().tfi_Monedas;
			this._tableFuentesDeCambio = mz.erp.businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio;
			
			_tableCuentasDeImputacion = mz.erp.businessrules.tsy_TiposMovimientos.GetListPorSigno("-1").Tables[0];
			_tableCuentasDeImputacion = VariablesListComparer.FilterDataTable(this._processParent.Process.ProcessName, this.GetTaskName(), "TipoMovimiento", "IdTipoMovimiento", _tableCuentasDeImputacion);

			_tableSubcuentasDeImputacion = (new tsy_SubTipoMovimientoDataset()).Tables[0];
			_comprobante.MesDeImputacion = _comprobante.FechaComprobante.Month.ToString() + "/" + this._comprobante.FechaComprobante.Year.ToString();
			_comprobante.MesDeDevengamiento = _comprobante.FechaComprobante.Month.ToString() + "/" + this._comprobante.FechaComprobante.Year.ToString();

			Autorizada = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "AutorizaPorDefault", true);
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "PreguntarAlCancelar");
			_allowToShowWarningTotalConMonto0 = Variables.GetValueBool(this._processParent.Process.ProcessName, this.GetTaskName(), "Emision.Validar.TotalConMonto0.MostrarWarning", _allowToShowWarningTotalConMonto0);
			_allowShow = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "VisualizaVentana", _allowShow);
			GetConceptos();
		}

		private void GetConceptos()
		{
			DataTable t = mz.erp.businessrules.tpu_NetosImpuestos.GetListNetosAsociados(this.TipoComprobanteDestino);
			_tableNetosGravados = t.Copy();
			_tableNetosNOGravados = t.Copy();
		}


		

		private void InitEventHandlers()
		{
			_comprobante.NetoChanged+=new EventHandler(_comprobante_NetoChanged);
			_comprobante.TotalChanged+=new EventHandler(_comprobante_TotalChanged);
			_comprobante.TipoDeComprobanteDestinoChanged+=new EventHandler(_comprobante_TipoDeComprobanteDestinoChanged);
			_comprobante.IdCuentaImputacionProveedorChanged+=new EventHandler(_comprobante_IdCuentaImputacionProveedorChanged);			
			_comprobante.IdSubCuentaImputacionProveedorChanged+=new EventHandler(_comprobante_IdSubCuentaImputacionProveedorChanged);
			_comprobante.IdMonedaOrigenChanged +=new EventHandler(_comprobante_IdMonedaOrigenChanged);
			_comprobante.TotalUsuarioChanged +=new EventHandler(_comprobante_TotalUsuarioChanged);
			_comprobante.NetoItemsOriginalChanged +=new EventHandler(_comprobante_NetoItemsOriginalChanged);
			_comprobante.CondicionDeCompraChanged +=new EventHandler(_comprobante_CondicionDeCompraChanged);
		}

		private void SetEditablesProperty()
		{
			string Tarea = _taskName;
			string Proceso = this._processParent.Process.ProcessName;
			_allowEditTipoDeComprobante = ComprobantesRules.Momentos_Parametros_Bool( Tarea,Proceso, "Emision.Editar.TComp");
			_allowEditProveedor = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.Proveedor");
			_allowEditFecha = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso,"Emision.Editar.Fecha");
			_allowEditFechaRegistracion = ComprobantesRules.Momentos_Parametros_Bool( Tarea,Proceso, "Emision.Editar.FechaRegistracion");
			_allowEditItems = ComprobantesRules.Momentos_Parametros_Bool( Tarea,Proceso, "Emision.Editar.Items");
			_allowDeleteItems = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Delete.Items", _allowDeleteItems);
			_allowAddItems = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Add.Items", _allowAddItems);
			_allowEditResponsableEmision = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso,"Emision.Editar.REmision");
			_allowEditNumeration = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso,"Emision.Editar.Numeracion");
			_actualizaNumeracion = ! ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso,"Emision.Editar.Numeracion");
			_allowToValidateNumeracion = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso,"Emision.Validar.Numeracion");
			_allowToValidateCampoAuxiliar1 = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso,"Emision.Validar.CampoAuxiliar1");
			_allowEditMonedaOrigen = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.MonedaOrigen");
			_allowEditFuenteDeCambio = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.FuenteDeCambio");			
			_allowToValidateNetoAcumuladoInvalido =  ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Validar.NetoAcumualdoInvalido", true);			
			_allowToValidateProveedor = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso,"Emision.Validar.Proveedor");
			_comprobante.CategoriaImpositivaProveedorAfectaTipoDeComprobanteDestino = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.TipoComprobanteDependeProveedor");
			_comprobante.AllowConceptosRepetidos = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso,"Emision.Validar.ConceptosRepetiodos");
			_allowEditCAI = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.CAI", _allowEditCAI);			
			_allowEditDescuentos = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.Descuentos", _allowEditDescuentos);			
			_allowEditDiasDemoraEntrega = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.DiasDemoraEntrega", _allowEditDiasDemoraEntrega);			
			_allowEditDiasVencimiento = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.DiasVencimiento", _allowEditDiasVencimiento);			
			_allowEditFechaVencimiento = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.FechaVencimiento", _allowEditFechaVencimiento);			
			_allowEditLeyenda = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.Leyenda", _allowEditLeyenda);			
			_allowEditMesImputacion = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.MesImputacion", _allowEditMesImputacion);
			_allowEditMesDevengamiento = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.MesDevengamiento", _allowEditMesDevengamiento);
			_allowEditNeto = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.Neto", _allowEditNeto);			
			_allowEditNetoBruto = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.NetoBruto", _allowEditNetoBruto);			
			_allowEditPorcentajeDescuentos = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.PorcentajeDescuentos", _allowEditPorcentajeDescuentos);			
			_allowEditProximaFechaVencimiento = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Editar.ProximaFechaVencimiento", _allowEditProximaFechaVencimiento);			
			_allowToValidateCondicionDeCompra = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso,"Emision.Validar.CondicionDeCompra", _allowToValidateCondicionDeCompra);
			_allowEditCuentaImputacion = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.CuentaImputacion", _allowEditCuentaImputacion);
			_allowEditSubcuentaImputacion = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.SubCuentaImputacion", _allowEditSubcuentaImputacion);
			_allowEditCondicionDeCompra = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.CondicionDeCompra", _allowEditCondicionDeCompra);
			_allowEditImpuestos = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.Impuestos", _allowEditImpuestos);
			_allowEditTotalUsuario = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.TotalUsuario", _allowEditTotalUsuario);
		    _allowEditTotalUsuarioMonedaReferencia = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.TotalUsuarioMonedaReferencia");
			_allowEditTotalDesdeImpuestos = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.TotalDesdeImpuestos", _allowEditTotalDesdeImpuestos);
			_allowEditTipoDeNetoGravados = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.TipoDeNetoGravados", _allowEditTipoDeNetoGravados);
			_allowEditImpuestoAplicadoNetoGravado = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.ImpuestoAplicadoNetoGravado", _allowEditImpuestoAplicadoNetoGravado);
            _allowEditNetoGravadoAplicado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.NetoGravadoAplicado", _allowEditNetoGravadoAplicado);
			_allowEditPorcentajeImpuestoAplicadoNetoGravado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.PorcentajeImpuestoAplicadoNetoGravado", _allowEditPorcentajeImpuestoAplicadoNetoGravado);
			_allowEditValorImpuestoAplicadoNetoGravado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.ValorImpuestoAplicadoNetoGravado", _allowEditValorImpuestoAplicadoNetoGravado);
			_allowEditTotalNetoGravado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.TotalNetoGravado", _allowEditTotalNetoGravado);
			_allowEditNetosGravados  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.NetosGravados", _allowEditNetosGravados);
			_allowEditConceptosNoGravados  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.ConceptosNoGravados", _allowEditConceptosNoGravados);
			_allowEditConceptoNoGravadoAplicado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.ConceptoNoGravadoAplicado", _allowEditConceptoNoGravadoAplicado);
			_allowEditImpuestoAplicadoConceptoNOGravado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.ImpuestoAplicadoConceptoNOGravado", _allowEditImpuestoAplicadoConceptoNOGravado);
			_allowEditTipoConceptoNoGravado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.TipoConceptoNoGravado", _allowEditTipoConceptoNoGravado);
			_allowEditPorcentajeImpuestoAplicadoConceptoNOGravado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.PorcentajeImpuestoAplicadoConceptoNOGravado", _allowEditPorcentajeImpuestoAplicadoConceptoNOGravado);
			_allowEditValorImpuestoAplicadoConceptoNOGravado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.ValorImpuestoAplicadoConceptoNOGravado", _allowEditValorImpuestoAplicadoConceptoNOGravado);
			_allowEditTotalConceptoNOGravado  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.TotalConceptoNOGravado", _allowEditTotalConceptoNOGravado);
			_allowEditTotalGeneral  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.TotalGeneral", _allowEditTotalGeneral);
			_allowEditDescuentoGeneral  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.DescuentoGeneral", _allowEditDescuentoGeneral);
			_allowEditPorcentajeDescuentoGeneral  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.PorcentajeDescuentoGeneral", _allowEditPorcentajeDescuentoGeneral);
			_allowEditTotal  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.Total", _allowEditTotal);
			_allowEditNetoItems  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.NetoItems", _allowEditNetoItems);
			_allowEditNetoItemsReal  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.NetoItemsReal", _allowEditNetoItemsReal);
			_allowEditObservaciones  = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Editar.Observaciones", _allowEditObservaciones);
			_allowToValidateFacturaPoseePagos = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Validar.FacturaPoseePagos", _allowToValidateFacturaPoseePagos);
			_allowToValidateTotalUsuario = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Validar.TotalGeneral", _allowToValidateTotalUsuario);
            /* Silvina 20101019 - Tarea 876 */
            _allowToValidateImpuestos = ComprobantesRules.Momentos_Parametros_Bool( Tarea, Proceso, "Emision.Validar.TotalImpuestos", _allowToValidateImpuestos);
            /* Fin Silvina */
            /* Silvina 20110601 - Tarea 0000147 */
            _allowValidateFechaProximoVencimiento = ComprobantesRules.Momentos_Parametros_Bool(Tarea, Proceso, "Emision.Validar.FechaProximoVencimiento", _allowValidateFechaProximoVencimiento);
            /* Fin Silvina 20110601 - Tarea 0000147*/
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
			if (!IsValidResponsable())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Responsable","IdResponsable","El responsable de emisión no puede ser nulo"));
			}
			if (!IsValidProveedor())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Proveedor","IdProveedor","Debe seleccionar el Proveedor"));
			}
			if (!IsValidNumeration())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Numero","Numero","Debe Ingresar el numero del comprobante"));
			}
			if (!IsValidNumerationForProveedor())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Numero","Numero","Ya existe el numero de comprobante para el Proveedor seleccionado"));
			}

			if (!IsValidNumeroFacturaForProveedor())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Numero","Numero","Ya existe el numero Factura para el Proveedor seleccionado"));
			}
			if (!IsValidItems())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Items","Items","No ha seleccionado ningun item"));
			}
			if (!IsValidCotizacion())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Cotizacion","Cotizacion","El Valor de la Cotizacion no es Valido"));
			}
			if(!IsValidCuentaImputacion())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Cuenta de Imputación","Cuenta de Imputación","Debe seleccionar una Cuenta de Imputación"));
			}
			if(!IsValidNetoAcumulado())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Neto Acumulado Inválido","Neto Acumulado Inválido","El Neto acumulado en los conceptos supera el Neto con Descuentos del comprobante"));
			}
			if(!IsValidTotal())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Total Inválido","Total Inválido","El total ingresado no coincide con el generado a partir de los netos"));
			}	
			if(!IsValidTotalItemsTotalUsuario())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Total Inválido","Total Inválido","El total obtenido a partir de los items no coincide con el total ingresado"));
			}	
			if(!IsValidMesImputacion())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Mes de Imputación","Mes de Imputación","El Mes de Imputación es inválido"));
			}
			if(!IsValidMesDevengamiento())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Mes de Devengamiento","Mes de Devengamiento","El Mes de Devengamiento es inválido"));
			}
			if(!IsValidCondicionDeCompra())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Condición de Compra","Condición de Compra","Debe seleccionar una Condición de Compra"));
			}
			if(!IsValidFacturaNoPoseePagos())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Factura con pagos realizados","Factura con pagos realizados","La Factura seleccionada posee pagos asociados"));
			}
			if(!IsValidTotalUsuario())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Factura con monto 0","Factura con monto 0","La Factura ingresada tiene monto 0"));
			}
			/* Silvina 20101019 - Tarea 876 */
            if(!IsValidImpuestos())
            {
                IsValid = false;
                _errores.Add(new ItemDatasetError("Impuestos", "Impuestos", "El total de los impuestos no coincide."));
            }
            /* Fin Silvina */
            /* Silvina 20110601 - Tarea 0000147 */
            if (!IsValidFechaProximoVencimiento())
            {
                IsValid = false;
                _errores.Add(new ItemDatasetError("Fecha Proximo Vencimiento", "Fecha Proximo Vencimiento", "La Fecha del Próximo Vencimiento no puede ser menor a la Fecha de Vencimiento."));
            }
            /* Fin Silvina 20110601 - Tarea 0000147*/
			return IsValid;
		}	

        /* Silvina 20101019 - Tarea 876 */
        private bool IsValidImpuestos()

        {
			if(_allowToValidateImpuestos)
				return _comprobante.IsValidImpuestos();
			return true;
		}
        /* Fin Silvina */

        /* Silvina 20110601 - Tarea 0000147 */
        private bool IsValidFechaProximoVencimiento()
        {
			if(_allowValidateFechaProximoVencimiento)
                return _comprobante.IsValidFechaProximoVencimiento();
			return true;
		}
        /* Fin Silvina 20110601 - Tarea 0000147 */

        private bool IsValidCondicionDeCompra()
		{
			if(_allowToValidateCondicionDeCompra)
				return _comprobante.IsValidCondicionDeCompra();
			return true;
		}

		public bool IsValidMesImputacion()
		{
			if(_comprobante.MesDeImputacion == null || _comprobante.MesDeImputacion == string.Empty) return false;
			string[] mesAñoDesde = _comprobante.MesDeImputacion.Split(new char[]{'/'});
			int mesEntrada = 0;
			int añoEntrada = 0;
			if(mesAñoDesde.Length == 2)
			{
				mesEntrada = Convert.ToInt32(mesAñoDesde[0]);
				añoEntrada = Convert.ToInt32(mesAñoDesde[1]);
				if(!(mesEntrada >=1 && mesEntrada <= 12))
					return false;
				// --------
				if(!PermiteMesImputacionMenor())
				{
					int mesActual = mz.erp.businessrules.Sistema.DateTime.Now.Month;
					int	añoActual = mz.erp.businessrules.Sistema.DateTime.Now.Year;
					bool valid = false;
					valid=(añoEntrada<añoActual)?false:(mesEntrada<mesActual)?false:true;
                    if (!valid)	return false;
                }
				// -------
			}			
			return true;
		}

		public bool IsValidFacturaNoPoseePagos()
		{
			if (_allowToValidateFacturaPoseePagos)
			{
				DataTable result = _comprobante.GetPagos();
				if (result.Rows.Count>0)
					return false;
			}
			return true;
		}

		public bool IsValidTotalUsuario()
		{
			if (_allowToValidateTotalUsuario)
			{
				if (_comprobante.TotalUsuario==0)
					return false;
			}
			return true;
		}

		
		public bool PermiteMesImputacionMenor()
		{
			return Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "PermiteMesImputacionMenor");
		}

		public bool PermiteMesDevengamientoMenor()
		{
			return Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "PermiteMesDevengamientoMenor");
		}

		public bool IsValidNetoAcumulado()
		{
			bool ok = true;
			if(_allowToValidateNetoAcumuladoInvalido)
			{
				ok = _comprobante.IsValidNetoAcumulado();
			}
			return ok;
		}
		
		public bool IsValidMesDevengamiento()
		{
			if(_comprobante.MesDeDevengamiento == null || _comprobante.MesDeDevengamiento == string.Empty) return false;
			string[] mesAñoDesde = _comprobante.MesDeDevengamiento.Split(new char[]{'/'});
			int mesEntrada = 0;
			int añoEntrada = 0;
			if(mesAñoDesde.Length == 2)
			{
				mesEntrada = Convert.ToInt32(mesAñoDesde[0]);
				añoEntrada = Convert.ToInt32(mesAñoDesde[1]);
				if(!(mesEntrada >=1 && mesEntrada <= 12))
				{
					// ---- Matias - 20090707 - Para respetar el inicio del nuevo campo Mes Devengamiento = '00/0000'
					if(mesEntrada==0 && añoEntrada==0)
					{
						string[] mesAñoDesdeOrig = _comprobante.MesDeDevengamientoOriginal.Split(new char[]{'/'});
						int mesEntradaOrig = 0;
						int añoEntradaOrig = 0;
						mesEntradaOrig = Convert.ToInt32(mesAñoDesdeOrig[0]);
						añoEntradaOrig = Convert.ToInt32(mesAñoDesdeOrig[1]);
						if(mesEntradaOrig==0 && añoEntradaOrig==0)
							return true;						
					}
					return false;
					// ---- Fin Matias.
				}
				if(!PermiteMesDevengamientoMenor())
				{
					int mesActual = mz.erp.businessrules.Sistema.DateTime.Now.Month;
					int	añoActual = mz.erp.businessrules.Sistema.DateTime.Now.Year;
					bool valid = false;
					valid=(añoEntrada<añoActual)?false:(mesEntrada<mesActual)?false:true;
					if (!valid)	return false;
				}				
			}			
			return true;
		}

		public bool IsValidTotalItemsTotalUsuario()
		{
			return  true;//_comprobante.IsValidTotalItemsTotalUsuario();
		}

		public bool IsValidTotal()
		{
			bool ok = true;
			if(_allowToValidateNetoAcumuladoInvalido)
			{
				ok = _comprobante.IsValidTotal();
			}
			return ok;
		}		
			
		public bool AllowShow() 
		{
			return _allowShow;
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
			StringBuilder result = new StringBuilder();				
			if(_allowToShowWarningTotalConMonto0)
			{
				if (_comprobante.TotalUsuario==0)
				{
					result.Append("El total de este comprobante es 0.");
					result.Append(System.Environment.NewLine);
					result.Append("¿Aun así desea continuar con esta operación?");
				}
			}
			if (result.Length>0)
				return result.ToString();
			return null;	
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
			_comprobante.SetProcessManagerParent(_processParent);
		}

		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
			_comprobante.SetTaskName(_taskName);
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
			_comprobante.GetData(data);
			return data;
		}

		public void Commit()
		{
			_comprobante.Commit();		
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_comprobante.Flush(IdTransaction);

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación ComprobanteDeCompraCabecera.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
            //German 20110315 - Tarea 0000038
            if (this._processParent.Process.ProcessName.Equals("ProcesoIngresarComprasCompleto"))
            {
                foreach (TaskCollectionData data in _processCollectionData)
                {
                    foreach (DataSet dataset in data)
                    {
                        string idComprobante = string.Empty;
                        string tipoDeComprobante = string.Empty;
                        if (dataset.DataSetName.Equals("tpu_ComprobantesDataset"))
                        {
                            DataTable table = dataset.Tables["tpu_Comprobantes"];
                            DataRow row = table.Rows[0];
                            tipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
                            if (tipoDeComprobante.Equals("CRMXC"))
                            {
                                idComprobante = (string)row["IdComprobante"];
                               
                                TaskCollectionData dataaux = new TaskCollectionData();
                                this._comprobante.GetData(dataaux);
                                foreach (DataSet datasetaux in dataaux)
                                {

                                    if (datasetaux.DataSetName.Equals("tpu_ComprobantesRelacionOrigenDestinoDataset"))
                                    {
                                        foreach (DataRow rowROD in datasetaux.Tables[0].Rows)
                                        {
                                            rowROD["IdComprobanteOrigen"] = idComprobante;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            
            }
            //Fin German 20110315 - Tarea 0000038

		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			// TODO: agregar la implementación ComprobanteDeCompraCabecera.GetSentenceReplication
			return null;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación ComprobanteDeCompraCabecera.GetHasSaved
			return false;
		}

		#endregion
		#region Variables privadas
		
		#endregion
		#region Propiedades

		public string TipoDeComprobanteDestino
		{
			get{return _comprobante.TipoComprobanteDestino;}
		}

		public string IdCondicionDeCompra
		{
			get{return _comprobante.IdCondicionDeCompra;}
			set
			{
				_comprobante.IdCondicionDeCompra = value;
				this.DiasVencimiento = _comprobante.DiasVencimientoPago;
			}
		}

		public decimal NetoItems
		{
			get{return _comprobante.NetoItems;}
		}

		public decimal NetoItemsOriginal
		{
			get{return _comprobante.NetoItemsOriginal;}
		}

		public decimal TotalUsuarioMonedaReferencia
		{
			get
			{
				return _comprobante.TotalUsuarioMonedaReferencia;
			}
		}

		
		public string IdResponsable
		{
			get{return _comprobante.IdResponsable;}
			set
			{
				if(_comprobante.IdResponsable != value)
				{
					_comprobante.IdResponsable = value;
					/*if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());*/
				}

			}
		}
		public string IdProveedor
		{
			get
			{
				if(_comprobante.Proveedor != null)
				{
					return _comprobante.Proveedor.IdProveedor;
				}
				return string.Empty;
			}
			/*set
			{
				if(_comprobante.Proveedor != null)
				{
					if(_comprobante.Proveedor.IdProveedor != value)
					{

						_comprobante.Proveedor.IdProveedor = value;						
						_comprobante.UpdateDataFromProveedor(_comprobante.Proveedor);
					}
				}

			}*/
		}

		public string CodigoProveedor
		{
			get
			{
				if(_comprobante.Proveedor != null)
				{
					return _comprobante.Proveedor.Codigo;
				}
				return string.Empty;
			}
			set
			{
				if(_comprobante.Proveedor != null)
				{
					if(_comprobante.Proveedor.Codigo != value)
					{
						Proveedor proveedor = new Proveedor();
						proveedor.GetCuenta_CodigoProveedor(value);
						_comprobante.Proveedor.IdProveedor = proveedor.IdProveedor;						
						_comprobante.UpdateDataFromProveedor(_comprobante.Proveedor);
					}
				}

			}
		}

		public string Numero
		{
			get{return _comprobante.Numero;}
			set
			{
				if(_comprobante.Numero != value)
				{
					_comprobante.Numero = value;
					_cambioNumero = true;
					/*if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());*/
				}		
			}
		}
				

		
		public string Mascara
		{
			get{return _comprobante.Mascara;}
			
		}
	
		
		
		public string TipoComprobanteDestino
		{
			set 
			{
				if(_comprobante.TipoComprobanteDestino != value)
				{
					if(value != null && value != string.Empty && _comprobante.TipoComprobanteDestino != value)
					{
						_comprobante.TipoComprobanteDestino = value; 
						this.AddImpuestosComprobante();
						/*
						if(TipoDeComprobanteDestinoChanged != null)
							TipoDeComprobanteDestinoChanged(this, new EventArgs());
							*/
					}
				}
			}
			get { return _comprobante.TipoComprobanteDestino ; }
		}
		
		public  string IdCuentaImputacion 
		{
			get{return _comprobante.IdCuentaImputacion;}
			set
			{
				if(value != null && value != string.Empty)
				{
					if(_comprobante.IdCuentaImputacion != value)
					{
						_comprobante.IdCuentaImputacion = value;
						SetSubCuentasImputacion();						
					}
				}

			}
		}
		private void SetSubCuentasImputacion()
		{
			_tableSubcuentasDeImputacion = mz.erp.businessrules.tsy_SubTipoMovimiento.GetList(_comprobante.IdCuentaImputacion).Tables[0];
			_tableSubcuentasDeImputacion = VariablesListComparer.FilterDataTable(this._processParent.Process.ProcessName, this.GetTaskName(), "SubTipoMovimiento", "IdSubTipoMovimiento", _tableSubcuentasDeImputacion);

			if (_tableSubcuentasDeImputacion.Rows.Count == 1)
			{
				_comprobante.IdSubCuentaImputacion = Convert.ToString(_tableSubcuentasDeImputacion.Rows[0]["IdSubTipoMovimiento"]);							
			}
			else
				_comprobante.IdSubCuentaImputacion = string.Empty;
			if(IdCuentaImputacionChanged != null)
				IdCuentaImputacionChanged(this, new EventArgs());
		}
		
		public string IdSubCuentaImputacion
		{
			get{return _comprobante.IdSubCuentaImputacion;}
			set{_comprobante.IdSubCuentaImputacion = value;}
		}
		
		public string CAI
		{
			get{return _comprobante.CAI;}
			set{_comprobante.CAI = value;}
		}
		public string Leyenda
		{
			get{return _comprobante.Leyenda;}
			set{_comprobante.Leyenda = value;}
		}
		
		public string Observaciones
		{
			get{return _comprobante.Observaciones;}
			set{_comprobante.Observaciones = value;}
		}
		public DateTime FechaRegistracion
		{
			get{return _comprobante.FechaRegistracion;}
			set{_comprobante.FechaRegistracion = value;}
		}		

		public DateTime FechaComprobante
		{
			get{return _comprobante.FechaComprobante;}
			set
			{
				if(_comprobante.FechaComprobante != value)
				{
					_comprobante.FechaComprobante = value;
					DateTime aux = mz.erp.systemframework.Util.GetStartDay(_comprobante.FechaComprobante);
					_comprobante.FechaVencimiento = aux.AddDays(_diasVencimiento);
					if(DiasVencimientoChanged != null)
						DiasVencimientoChanged(this, new EventArgs());
				}

			}
		}
		
		private int _diasVencimiento = 0;
		public int DiasVencimiento
		{
			get{return _diasVencimiento;}
			set
			{
				if(_diasVencimiento != value)
				{
					_diasVencimiento = value;
					DateTime aux = mz.erp.systemframework.Util.GetStartDay(_comprobante.FechaComprobante);
					_comprobante.FechaVencimiento = aux.AddDays(value);
                    //German 20120510 - Tarea 0000320
                    if (_comprobante.ProximaFechaVencimiento < _comprobante.FechaVencimiento)
                        _comprobante.ProximaFechaVencimiento = _comprobante.FechaVencimiento;
                    //Fin German 20120510 - Tarea 0000320
					if(DiasVencimientoChanged != null)
						DiasVencimientoChanged(this, new EventArgs());
				}
			}
		}

		public  DateTime FechaVencimiento
		{
			get{return _comprobante.FechaVencimiento;}
			set
			{
				if(_comprobante.FechaVencimiento != value)
				{
					_comprobante.FechaVencimiento = value;
					DateTime aux = mz.erp.systemframework.Util.GetStartDay(_comprobante.FechaComprobante);
					System.TimeSpan result = _comprobante.FechaVencimiento.Subtract(aux);
					_diasVencimiento = result.Days<0?0:result.Days;
                    //German 20120510 - Tarea 0000320
                    if (_comprobante.ProximaFechaVencimiento < _comprobante.FechaVencimiento)
                        _comprobante.ProximaFechaVencimiento = _comprobante.FechaVencimiento;
                    //Fin German 20120510 - Tarea 0000320
					if(FechaVencimientoChanged != null)
						FechaVencimientoChanged(this, new EventArgs());

				}
			}
		}
		public DateTime ProximaFechaVencimiento
		{
			get{return _comprobante.ProximaFechaVencimiento;}
			set{_comprobante.ProximaFechaVencimiento = value;}
		}

		public  string MesDeImputacion
		{
			get{return _comprobante.MesDeImputacion;}
			set{_comprobante.MesDeImputacion = value;}
		}

		public  string MesDeDevengamiento
		{
			get{return _comprobante.MesDeDevengamiento;}
			set{_comprobante.MesDeDevengamiento = value;}
		}
		
		public string IdMonedaOrigen
		{
			get{return _comprobante.IdMonedaOrigen;}
			set
			{
				if(_comprobante.IdMonedaOrigen != value)
				{
					_comprobante.IdMonedaOrigen = value;
				}
			}
		}

		
		public string SimboloMonedaOrigen
		{
			get
			{
				return _comprobante.SimboloMonedaOrigen;
			}
			set
			{
				_comprobante.SimboloMonedaOrigen = value;
			}
		}

		public string SimboloMonedaCierre
		{
			get
			{
				return _comprobante.SimboloMonedaCierre;
			}
		}

		public string IdFuenteDeCambioProveedor
		{
			get{return _comprobante.IdFuenteDeCambioProveedor;	}
			set
			{
				if(value != _comprobante.IdFuenteDeCambioProveedor)
				{
					_comprobante.IdFuenteDeCambioProveedor = value;
				}
			}		
		}
		
		public Cotizacion CotizacionProveedor
		{
			get{return _comprobante.CotizacionProveedor;}
		}

		
		public decimal ValorCotizacionProveedor
		{
			get
			{
				return _comprobante.ValorCotizacionProveedor;
			}
			set
			{
				_comprobante.ValorCotizacionProveedor = value;
			}
		}
		
		public decimal NetoBruto
		{
			get{return _comprobante.NetoBruto;}
			set
			{
				if(_comprobante.NetoBruto != value)
				{
					_comprobante.NetoBruto = value;					
				}
			}
		}	

		public decimal Descuentos 
		{
			get{return _comprobante.Descuentos;}
			set
			{
				if(_comprobante.Descuentos != value)
				{
					_comprobante.Descuentos = value;
				}
			}
		}

		public decimal PorcentajeDescuentos 
		{
			get{return _comprobante.PorcentajeDescuentos;}
			set
			{
				if(_comprobante.PorcentajeDescuentos != value)
				{
					_comprobante.PorcentajeDescuentos = value;					
				}
			}
		}	
	
		public decimal Neto 
		{
			get{return _comprobante.Neto;}
			set{_comprobante.Neto = value;}
		}	
		public decimal Total 
		{
			get{return _comprobante.Total;}			
		}
		public decimal DescuentoGeneral 
		{
			get{return _comprobante.DescuentoGeneral;}
			set
			{
				if(_comprobante.DescuentoGeneral != value)
				{
					_comprobante.DescuentoGeneral = value;
				}
			}
		}		
		public decimal PorcentajeDescuentoGeneral 
		{
			get{return _comprobante.PorcentajeDescuentoGeneral;}
			set
			{
				if(_comprobante.PorcentajeDescuentoGeneral != value)
				{
					_comprobante.PorcentajeDescuentoGeneral = value;					
				}
			}
		}	
		public decimal TotalGeneral
		{
			get{return _comprobante.TotalGeneral;}			
		}
		/*
				private string _momento = string.Empty;
				public string Momento
				{
					get {return _momento;}
				}*/


		public decimal Impuestos
		{
			get{return _comprobante.Impuestos;}
			set{ _comprobante.Impuestos = value;}
		}
		
		public decimal TotalUsuario
		{
			get{return _comprobante.TotalUsuario;}
			set{ _comprobante.TotalUsuario = value;}
		}

		private DataTable _tableMonedas;
		public DataTable TableMonedas
		{
			get{return _tableMonedas;}
		}
		private DataTable _tableFuentesDeCambio;
		public DataTable TableFuentesDeCambio
		{
			get{return _tableFuentesDeCambio;}
		}
		
		
		public DataTable TableTiposDeComprobantesValidos
		{
			get
			{
				return _comprobante.TableTiposDeComprobantesValidos;
			}
		}

		private DataTable _tableCuentasDeImputacion;
		public DataTable TableCuentasDeImputacion
		{
			get{return _tableCuentasDeImputacion;}
		}

		private DataTable _tableSubcuentasDeImputacion = new DataTable();
		public DataTable TableSubcuentasDeImputacion
		{
			get{return _tableSubcuentasDeImputacion;}
		}

		public ItemsConcepto ConceptosGravados
		{
			get{return _comprobante.ConceptosGravados;}
		}

		public ItemsConcepto ConceptosNOGravados
		{
			get{return _comprobante.ConceptosNOGravados;}
		}

		private DataTable _tableNetosGravados = new DataTable();
		public DataTable TableNetosGravados
		{
			get{return _tableNetosGravados;}
		}
		
		private DataTable _tableNetosNOGravados = new DataTable();
		public DataTable TableNetosNOGravados
		{
			get{return _tableNetosNOGravados;}
		}

		public ItemsComprobantesCompra Items
		{
			get { return this._comprobante.Items; }
			set { this._comprobante.Items = value; }
		}

		public bool Autorizada
		{
			get { return _comprobante.Autorizada; }
			set { _comprobante.Autorizada = value;}
		}

		#endregion

		#region Variables Publicas Interfaz
		private bool _allowEditObservaciones = true;
		public bool AllowEditObservaciones
		{
			get{return _allowEditObservaciones;}
		}

		private bool _allowEditNetoItemsReal = false;
		public bool AllowEditNetoItemsReal
		{
			get{return _allowEditNetoItemsReal;}
		}

		private bool _allowEditNetoItems = false;
		public bool AllowEditNetoItems
		{
			get{return _allowEditNetoItems;}
		}

		private bool _allowEditTotal = false;
		public bool AllowEditTotal
		{
			get{return _allowEditTotal;}
		}

		private bool _allowEditPorcentajeDescuentoGeneral = true;
		public bool AllowEditPorcentajeDescuentoGeneral
		{
			get{return _allowEditPorcentajeDescuentoGeneral;}
		}

		private bool _allowEditDescuentoGeneral = true;
		public bool AllowEditDescuentoGeneral
		{
			get{return _allowEditDescuentoGeneral;}
		}

		private bool _allowEditTotalGeneral = false;
		public bool AllowEditTotalGeneral
		{
			get{return _allowEditTotalGeneral;}
		}

		private bool _allowEditTotalConceptoNOGravado = false;
		public bool AllowEditTotalConceptoNOGravado
		{
			get{return _allowEditTotalConceptoNOGravado;}
		}

		private bool _allowEditValorImpuestoAplicadoConceptoNOGravado = true;
		public bool AllowEditValorImpuestoAplicadoConceptoNOGravado
		{
			get{return _allowEditValorImpuestoAplicadoConceptoNOGravado;}
		}

		private bool _allowEditPorcentajeImpuestoAplicadoConceptoNOGravado = false;
		public bool AllowEditPorcentajeImpuestoAplicadoConceptoNOGravado
		{
			get{return _allowEditPorcentajeImpuestoAplicadoConceptoNOGravado;}
		}

		private bool _allowEditTipoConceptoNoGravado = true;
		public bool AllowEditTipoConceptoNoGravado
		{
			get{return _allowEditTipoConceptoNoGravado;}
		}

		private bool _allowEditImpuestoAplicadoConceptoNOGravado = true;
		public bool AllowEditImpuestoAplicadoConceptoNOGravado
		{
			get{return _allowEditImpuestoAplicadoConceptoNOGravado;}
		}
		
		private bool _allowEditConceptoNoGravadoAplicado = false;
		public bool AllowEditConceptoNoGravadoAplicado
		{
			get{return _allowEditConceptoNoGravadoAplicado;}
		}

		private bool _allowEditConceptosNoGravados = true;
		public bool AllowEditConceptosNoGravados
		{
			get{return _allowEditConceptosNoGravados;}
		}

		private bool _allowEditNetosGravados = true;
		public bool AllowEditNetosGravados
		{
			get{return _allowEditNetosGravados;}
		}

		private bool _allowEditTotalNetoGravado = true;//
		public bool AllowEditTotalNetoGravado
		{
			get{return _allowEditTotalNetoGravado;}
		}

		private bool _allowEditValorImpuestoAplicadoNetoGravado = true;
		public bool AllowEditValorImpuestoAplicadoNetoGravado
		{
			get{return _allowEditValorImpuestoAplicadoNetoGravado;}
		}

		private bool _allowEditPorcentajeImpuestoAplicadoNetoGravado = true;
		public bool AllowEditPorcentajeImpuestoAplicadoNetoGravado
		{
			get{return _allowEditPorcentajeImpuestoAplicadoNetoGravado;}
		}

		private bool _allowEditNetoGravadoAplicado = true;
		public bool AllowEditNetoGravadoAplicado
		{
			get{return _allowEditNetoGravadoAplicado;}
		}

		private bool _allowEditImpuestoAplicadoNetoGravado = true;
		public bool AllowEditImpuestoAplicadoNetoGravado
		{
			get{return _allowEditImpuestoAplicadoNetoGravado;}
		}

		private bool _allowEditTipoDeNetoGravados = true;
		public bool AllowEditTipoDeNetoGravados
		{
			get{return _allowEditTipoDeNetoGravados;}
		}

		private bool _allowEditTotalDesdeImpuestos = true;
		public bool AllowEditTotalDesdeImpuestos
		{
			get{return _allowEditTotalDesdeImpuestos;}
		}

		private bool _allowEditTotalUsuarioMonedaReferencia = false;
		public bool AllowEditTotalUsuarioMonedaReferencia
		{
			get{return _allowEditTotalUsuarioMonedaReferencia;}
		}

		private bool _allowEditTotalUsuario = true;
		public bool AllowEditTotalUsuario
		{
			get{return _allowEditTotalUsuario;}
		}

		private bool _allowEditImpuestos = false;
		public bool AllowEditImpuestos
		{
			get{return _allowEditImpuestos;}
		}

		private bool _allowEditCondicionDeCompra = true;
		public bool AllowEditCondicionDeCompra
		{
			get{return _allowEditCondicionDeCompra;}
		}

	    private bool _allowEditSubcuentaImputacion = true;
		public bool AllowEditSubcuentaImputacion
		{
			get{return _allowEditSubcuentaImputacion;}
		}

		private bool _allowEditCuentaImputacion = true;
		public bool AllowEditCuentaImputacion
		{
			get{return _allowEditCuentaImputacion;}
		}
		
		private bool _allowEditLeyenda = true;
		public bool AllowEditLeyenda
		{
			get{return _allowEditLeyenda;}
		}
		

		private bool _allowEditMesImputacion = true;
		public bool AllowEditMesImputacion
		{
			get{return _allowEditMesImputacion;}
		}

		private bool _allowEditMesDevengamiento = true;
		public bool AllowEditMesDevengamiento
		{
			get{return _allowEditMesDevengamiento;}
		}
		
		private bool _allowEditFechaVencimiento = true;
		public bool AllowEditFechaVencimiento
		{
			get{return _allowEditFechaVencimiento;}
		}
		private bool _allowEditDiasVencimiento = true;
		public bool AllowEditDiasVencimiento
		{
			get{return _allowEditDiasVencimiento;}
		}

		private bool _allowEditProximaFechaVencimiento = true;
		public bool AllowEditProximaFechaVencimiento
		{
			get{return _allowEditProximaFechaVencimiento;}
		}

		private bool _allowEditCAI = true;
		public bool AllowEditCAI
		{
			get{return _allowEditCAI;}
		}

		private bool _allowEditDiasDemoraEntrega = true;
		public bool AllowEditDiasDemoraEntrega
		{
			get{return _allowEditDiasDemoraEntrega;}
		}
		private bool _allowEditNetoBruto = true;
		public bool AllowEditNetoBruto
		{
			get{return _allowEditNetoBruto;}
		}
		private bool _allowEditNeto = true;
		public bool AllowEditNeto
		{
			get{return _allowEditNeto;}
		}
		private bool _allowEditDescuentos = true;
		public bool AllowEditDescuentos
		{
			get{return _allowEditDescuentos;}
		}
		private bool _allowEditPorcentajeDescuentos = true;
		public bool AllowEditPorcentajeDescuentos
		{
			get{return _allowEditPorcentajeDescuentos;}
		}

		private bool _allowEditTipoDeComprobante = true;
		public bool AllowEditTipoDeComprobante
		{
			set { _allowEditTipoDeComprobante = value; }
			get { return _allowEditTipoDeComprobante; }
		}

		private bool _allowEditProveedor = true;
		public bool AllowEditProveedor
		{
			set { _allowEditProveedor = value; }
			get { return _allowEditProveedor; }
		}

		private bool _allowEditFecha = true;
		public bool AllowEditFecha
		{
			set { _allowEditFecha = value; }
			get { return _allowEditFecha; }
		}	

		private bool _allowEditFechaRegistracion = false;
		public bool AllowEditFechaRegistracion
		{
			set { _allowEditFechaRegistracion = value; }
			get { return _allowEditFechaRegistracion; }
		}

		
		private bool _allowEditResponsableEmision = true;
		public bool AllowEditResponsableEmision
		{
			set { _allowEditResponsableEmision = value; }
			get { return _allowEditResponsableEmision; }
		}

		private bool _allowEditItems = true;
		public bool AllowEditItems
		{
			set { _allowEditItems = value; }
			get { return _allowEditItems; }
		}

		private bool _allowEditNumeration = false;
		public bool AllowEditNumeration
		{
			set { _allowEditNumeration = value;}
			get { return _allowEditNumeration; }
		}		

		private bool _actualizaNumeracion = true;
		public bool ActualizaNumeracion 
		{
			set { _actualizaNumeracion = value;}
			get { return _actualizaNumeracion; }
		}

		private bool _allowToValidateNumeracion = false;
		public bool AllowToValidateNumeracion
		{
			set{_allowToValidateNumeracion = value;}
			get{return _allowToValidateNumeracion ;}
		}

		private bool _allowToValidateCampoAuxiliar1 = false;
		public bool AllowToValidateCampoAuxiliar1
		{
			set{_allowToValidateCampoAuxiliar1 = value;}
			get{return _allowToValidateCampoAuxiliar1 ;}
		}

		private bool _allowToValidateFacturaPoseePagos = false;
		public bool AllowToValidateFacturaPoseePagos
		{
			set{_allowToValidateFacturaPoseePagos = value;}
			get{return _allowToValidateFacturaPoseePagos ;}
		}

//		private bool _allowToValidateTotalGeneral = false;
//		public bool AllowToValidateTotalGeneral
//		{
//			set{_allowToValidateTotalGeneral = value;}
//			get{return _allowToValidateTotalGeneral;}
//		}
		
		private bool _allowToValidateTotalUsuario = false;
		public bool AllowToValidateTotalUsuario
		{
			set{_allowToValidateTotalUsuario = value;}
			get{return _allowToValidateTotalUsuario;}
		}
		
		private bool _allowEditMonedaOrigen = false;
		public bool AllowEditMonedaOrigen
		{
			get{return _allowEditMonedaOrigen;}
		}

		public bool AllowEditFuenteDeCambio
		{
			get{return _allowEditFuenteDeCambio;}
		}
		private bool _allowEditFuenteDeCambio = false;

		private bool _allowDeleteItems = false;		
		public bool AllowDeleteItems
		{
			set { _allowDeleteItems = value; }
			get { return _allowDeleteItems; }
		}

		private bool _allowAddItems = true;
		public bool AllowAddItems
		{
			set { _allowAddItems = value; }
			get { return _allowAddItems; }
		}

		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}
	
		private bool _allowToValidateNetoAcumuladoInvalido = false;
		private bool _allowToValidateProveedor = true;		
		private bool _allowToValidateCondicionDeCompra = true;

		private bool _allowToShowWarningTotalConMonto0 = false;
		public bool AllowToShowWarningTotalConMonto0
		{
			get {return _allowToShowWarningTotalConMonto0;}
			set {_allowToShowWarningTotalConMonto0=value;}
		}
		
        /* Silvina 20101019 - Tarea 876 */
        private bool _allowToValidateImpuestos = false;
        /* Fin Silvina */

        /* Silvina 20110601 - Tarea 0000147 */
        private bool _allowValidateFechaProximoVencimiento = true;
        /* Fin Silvina 20110601 - Tarea 0000147 */

		#endregion	

		#region Metodos privados
		
		private bool IsValidCuentaImputacion()
		{
			return _comprobante.IdCuentaImputacion != null && !_comprobante.IdCuentaImputacion.Equals(string.Empty);
		}
		private bool IsValidResponsable()
		{
			return _comprobante.IdResponsable != null && !_comprobante.IdResponsable.Equals(string.Empty);
		}
		private bool IsValidProveedor()
		{
			/*
			if (_allowToValidateProveedor)
			*/
			   return this._comprobante.Proveedor != null && _comprobante.Proveedor.IdProveedor != null && !_comprobante.Proveedor.IdProveedor.Equals(string.Empty);
			/*
			return true;
			*/
		}
		private bool IsValidNumeration()
		{
			if (this.AllowToValidateNumeracion)
			{ 
				if ( (Numero.EndsWith("-") || (Numero == string.Empty))) 
				{
					return false;
				}
			}
			return true;
		}
		private bool IsValidNumerationForProveedor()
		{
			if (_cambioNumero && this.AllowToValidateNumeracion)
			{ 
				if(!(Numero.EndsWith("-") || Numero == string.Empty ) && IsValidProveedor())
				{
					return !ExistsNumeration(this.Numero, this.TipoComprobanteDestino, this.IdProveedor);
				}
				else return false;
			}
			return true;
		}

		


		private bool IsValidNumeroFacturaForProveedor()
		{
			/*if (this.AllowToValidateCampoAuxiliar1)
			{ 
				if(!(_campoAuxiliar1.EndsWith("-") || _campoAuxiliar1 == string.Empty || _campoAuxiliar1.Equals("A-0000-00000000")) && IsValidProveedor())
				{
					return !ExistsNumeroFactura(this._campoAuxiliar1, this._tipoComprobanteDestino, this.Proveedor.IdProveedor);
				}
				else return false;
			}
			else return true;*/
			return true;
		}
		private bool IsValidItems()
		{
			//German 20090422
			if(_comprobante.AllowValidateItems)
			{
				return _comprobante.Items != null && _comprobante.Items.Count > 0;
			}
			return true;
			//Fin German 20090422
		}
		private bool IsValidCotizacion()
		{
			string IdMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
			if(IdMonedaReferencia.Equals(this._comprobante.IdMonedaOrigen))
				return this._comprobante.ValorCotizacionProveedor == 1;
			return true;
		}
		
		private  bool ExistsNumeroFactura(string numero, string tipoDeComprobante, string IdProveedor)
		{
			return mz.erp.businessrules.tpu_Comprobantes.ExistsNumeroFactura(numero, tipoDeComprobante, IdProveedor);
		}

		private  bool ExistsNumeration(string numero, string tipoDeComprobante, string IdProveedor)
		{
			return mz.erp.businessrules.tpu_Comprobantes.ExistsNumeration(numero, tipoDeComprobante, IdProveedor);
		}

		private void Step(RelacionesComprobanteDeCompraOrigenDestino rod)
		{
			_comprobante.Step(rod);
			DateTime aux = mz.erp.systemframework.Util.GetStartDay(_comprobante.FechaComprobante);
			System.TimeSpan result = _comprobante.FechaVencimiento.Subtract(aux);
			_diasVencimiento = result.Days<0?0:result.Days;
			if(_comprobante.MesDeImputacion == null || _comprobante.MesDeImputacion.Equals(string.Empty))
				_comprobante.MesDeImputacion = _comprobante.FechaComprobante.Month.ToString() + "/" + this._comprobante.FechaComprobante.Year.ToString();
			if(_comprobante.MesDeDevengamiento == null || _comprobante.MesDeDevengamiento.Equals(string.Empty))
				_comprobante.MesDeDevengamiento = _comprobante.FechaComprobante.Month.ToString() + "/" + this._comprobante.FechaComprobante.Year.ToString();
			this.AddImpuestosComprobante();

		}

		private void AddImpuestosComprobante()
		{

            //German 20101105 - Tarea 915
			if(_processParent.Process.ProcessName.Equals("ProcesoComprarIngresarCabeceraCompras")
                || _processParent.Process.ProcessName.Equals("ProcesoComprarIngresarCabeceraComprasDV")
                //German 20110310 - Tarea 0000038
                || _processParent.Process.ProcessName.Equals("ProcesoIngresarComprasCompleto"))
                //Fin German 20110310 - Tarea 0000038
            //Fin German 20101105 - Tarea 915
			{				
				_comprobante.NetoBruto = _comprobante.Items.Neto;

				_comprobante.ConceptosGravados.RemoveAll();
				_comprobante.ConceptosNOGravados.RemoveAll();
				DataTable tableNI = tpu_NetosImpuestos.GetListImpuestosAsociados(_comprobante.TipoComprobanteDestino);
				foreach(DataRow rowNI in tableNI.Rows)
				{
					
					string IdImpuesto = Convert.ToString(rowNI["IdImpuesto"]);
					tsy_ImpuestosDataset.tsy_ImpuestosRow rowI = tsy_Impuestos.GetByPk(IdImpuesto);
					string IdNeto = Convert.ToString(rowNI["IdNeto"]);
					string DescripcionNeto = Convert.ToString(rowNI["Neto"]);
					string Codigo = Convert.ToString(rowNI["CodigoNeto"]);
					string DescripcionImpuesto = Convert.ToString(rowI["Descripcion"]);
					decimal Neto = 0;
					bool agregarImpuesto = false;
					bool EsGravado = Convert.ToBoolean(rowNI["EsGravado"]);
					decimal PorcentajeAplicado = Decimal.Round(Convert.ToDecimal(rowI["Alicuota1"]),2);
					/**
					 * Excluye el Gasto Gravado dado que los ITEMS pueden ser Servicios o Articulos. 
					 * De esta forma solo tiene en cuenta el Neto Gravado y Servicio Gravado, de manera que
					 * si la factura de Compra tiene configurado en Neto de Gasto, este no se tiene
					 * en cuenta cuando se hace una factura de compras de remito.
					*/

					if(!Codigo.ToUpper().Equals("GASTOGRAVADO"))
					{
						foreach (ItemComprobanteCompra item in _comprobante.Items)
						{
							tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow rowIP = tsy_ImpuestosProductos.GetByPk(item.IdProducto, IdImpuesto);
							if(rowIP != null)
							{
								Neto = Neto + item.PrecioDeCosto * item.Cantidad;
								agregarImpuesto = true;
							}
						
						}
						if(agregarImpuesto)
						{
							Neto = Decimal.Round(Neto, 2);
							decimal ImpuestoAplicado =  Decimal.Round((Neto * PorcentajeAplicado)/100, 2);
							decimal Total =  Decimal.Round(ImpuestoAplicado + Neto, 2);
							if(EsGravado)
								this.AddNetoGravado(IdNeto, DescripcionNeto, IdImpuesto, DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
							else
								this.AddNetoNOGravado(IdNeto, DescripcionNeto, IdImpuesto, DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
						}
					}
				}
				if(NetosCollectionChanged != null)
					NetosCollectionChanged(this, new EventArgs());
			}

		}


		private void StepEdit(RelacionesComprobanteDeCompraOrigenDestino rod)
		{
			_comprobante.StepEdit(rod);
			GetConceptos();
			/*
			DateTime aux = mz.erp.systemframework.Util.GetStartDay(_comprobante.FechaComprobante);
			System.TimeSpan result = _comprobante.FechaVencimiento.Subtract(aux);
			_diasVencimiento = result.Days<0?0:result.Days;
			if(_comprobante.MesDeImputacion == null || _comprobante.MesDeImputacion.Equals(string.Empty))
				_comprobante.MesDeImputacion = _comprobante.FechaComprobante.Month.ToString() + "/" + this._comprobante.FechaComprobante.Year.ToString();			
			*/
		}

		private void Edit(string IdComprobante)
		{
			_comprobante.Edit(IdComprobante);
		}

		private void UpdateFromComprobanteDeCompra(ComprobanteDeCompra comp) 
		{			
			_comprobante.UpdateDataFromProveedor(comp.Proveedor);
			_comprobante.FechaComprobante = comp.FechaComprobante;
			_comprobante.FechaRegistracion = mz.erp.businessrules.Sistema.DateTime.Now;
			_comprobante.Numero = comp.Numero;
			_comprobante.SetItems(comp.Items);
	
		}
		private void UpdateFromIngresarPrecioProducto(IngresarPrecioProducto task)
		{
			
			this._comprobante.UpdateFromIngresarPrecioProducto(task);
            //German 20110310 - Tarea 0000038
            AddImpuestosComprobante();
            //Fin German 20110310 - Tarea 0000038
				
		}
		#endregion
		#region Metodos publicos

		public void RemoveItem (comprobantes.ItemComprobanteCompra item)
		{
			_comprobante.RemoveItem(item);
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		public void AddItems(ArrayList items)
		{
			_comprobante.AddItems(items);
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		public void AddNetoGravado(string IdNetoGravado, string DescripcionNeto, string IdImpuestoAplicado, string DescripcionImpuesto, decimal Neto, decimal  PorcentajeAplicado, decimal ImpuestoAplicado, decimal Total)
		{
			try
			{
				_comprobante.AddNetoGravado(IdNetoGravado, DescripcionNeto, IdImpuestoAplicado, DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
			}
			catch(ConceptoRepetidoException cre)
			{
				throw cre;
			}
			catch(NetoAcumuladoInvalidoException naie)
			{
				throw naie;		
			}
		}
		
		public void AddNetoNOGravado(string IdNetoNOGravado, string DescripcionNeto, string IdImpuestoAplicado, string DescripcionImpuesto, decimal Neto, decimal  PorcentajeAplicado, decimal ImpuestoAplicado, decimal Total)
		{
			try
			{
				_comprobante.AddNetoNOGravado(IdNetoNOGravado, DescripcionNeto, IdImpuestoAplicado, DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
			}
			catch(ConceptoRepetidoException cre)
			{
				throw cre;
			}
			catch(NetoAcumuladoInvalidoException naie)
			{
				throw naie;
			}
		}
        //Cristian Tarea 879
        //German 20101111 - Tarea 933
        public void updateNetoAplicable(String conceptoModificar, string IdImpuesto, decimal valorImpuestoModificado)
        {
            _comprobante.updateConcepto(conceptoModificar,IdImpuesto,valorImpuestoModificado);
        }
        //Fin German 20101111 - Tarea 933
        //Tarea 879

        //German Tarea 879
        //German 20101111 - Tarea 933
        public void updateImpuesto(String idConcepto, String IdImpuesto, decimal valorNetoModificado)
        {
            _comprobante.updateImpuesto(idConcepto, IdImpuesto, valorNetoModificado);
        }
        //Fin German 20101111 - Tarea 933
        //Fin German Tarea 879
		public void RefreshTotal()
		{
			_comprobante.RecalcularTotal();
		}


		public string FillNumberWithZeros(string txt)
		{
			string separator = Variables.GetValueString("Comprobante.TiposDeComprobante.Numeracion.Separador");
			int cant1 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion1.Longitud") );
			int cant2 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion2.Longitud") );
			return mz.erp.systemframework.Util.FillNumberWithZeros(txt, separator, cant1, cant2);
		}

		#endregion

		private void _comprobante_NetoChanged(object sender, EventArgs e)
		{
			if(NetoChanged != null)
				NetoChanged(this, new EventArgs());
		}
		private void _comprobante_TotalChanged(object sender, EventArgs e)
		{
			if(TotalChanged != null)
				TotalChanged(this, new EventArgs());
		}
		private void _comprobante_TipoDeComprobanteDestinoChanged(object sender, EventArgs e)
		{						
			GetConceptos();	
			if(TipoDeComprobanteDestinoChanged != null)
				TipoDeComprobanteDestinoChanged(this, new EventArgs());			
		}

		private void _comprobante_IdCuentaImputacionProveedorChanged(object sender, EventArgs e)
		{
			if(IdCuentaImputacionProveedorChanged != null)
				IdCuentaImputacionProveedorChanged(this, new EventArgs());
			_tableSubcuentasDeImputacion = mz.erp.businessrules.tsy_SubTipoMovimiento.GetList(_comprobante.IdCuentaImputacion).Tables[0];
			if(IdCuentaImputacionChanged != null)
				IdCuentaImputacionChanged(this, new EventArgs());
			//SetSubCuentasImputacion();
		}

		private void _comprobante_IdSubCuentaImputacionProveedorChanged(object sender, EventArgs e)
		{
			if(IdSubCuentaImputacionProveedorChanged != null)
				IdSubCuentaImputacionProveedorChanged(this, new EventArgs());
		}

		private void _comprobante_IdMonedaOrigenChanged(object sender, EventArgs e)
		{
			if(IdMonedaOrigenChanged != null)
				IdMonedaOrigenChanged(this, new EventArgs());
		}

		private void _comprobante_TotalUsuarioChanged(object sender, EventArgs e)
		{
			if(TotalUsuarioChanged != null)
				TotalUsuarioChanged(this, new EventArgs());
		}

		private void _comprobante_NetoItemsOriginalChanged(object sender, EventArgs e)
		{
			if(NetoItemsOriginalChanged != null)
				NetoItemsOriginalChanged(this, new EventArgs());
		}

		private void _comprobante_CondicionDeCompraChanged(object sender, EventArgs e)
		{
			if(CondicionDeCompraChanged != null)
				CondicionDeCompraChanged(this, new EventArgs());
		}
	}	
}
