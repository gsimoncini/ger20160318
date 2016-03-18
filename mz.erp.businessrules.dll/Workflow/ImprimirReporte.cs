 using System;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.businessrules.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Tiene la capacidad de imprimir un reporte obteniendo los datos de la clase que se le indique en las variables
	/// Lee los datos de la clase por reflexión y prepara el ReportParameterCollection para luego invocar al reporte
	/// Debido a que debe existir una correpondencia entre Nombres de Tareas y clases que la soportan se relacionan
	/// las tareas ImprimirReporte, ImprimirReporteB, ImprimirReporteC, ImprimirReporteD de manera que puedan declararse
	/// hasta cuatro tareas diferentes que requieran imprimir un reporte en el mismo proceso.
	/// Debido a que cada tarea (ImprimirReporte) podria presentarse en diferentes procesos como contexto para obtener
	/// la informacion de funcionamiento debe indicar el proceso que lo contiene.
	/// </summary>
	/// <remarks>
	/// Variables que utiliza: 
	/// Momentos.NombreTarea.NombreDelProceso.TareaPrevia
	/// Momentos.NombreTarea.NombreDelProceso.Atributos
	/// Momentos.NombreTarea.NombreDelProceso.Reporte
	/// </remarks>
	/// 
	public class ImprimirReporte: ITask, IDependentPersistentTask
	{

		public ImprimirReporte()
		{
			
		}

		#region Propiedades

		public bool AllowImpresoraPorTipoDeComprobante
		{
			get{return _allowImpresoraPorTipoDeComprobante;}
		}

		public string ImpresoraPorTipoDeComprobante
		{
			get
			{
				if(_allowImpresoraPorTipoDeComprobante)
					if(_impresorasPorTipoDeComprobante.ContainsKey(this._idTipoDeComprobante))
						return Convert.ToString(_impresorasPorTipoDeComprobante[this._idTipoDeComprobante]);
				return null;
			}
		}

        //German 20100713 - Tarea 793
        public bool AllowBandejaPorTipoDeComprobante
        {
            get { return _allowBandejaPorTipoDeComprobante; }
        }

        public string BandejaPorTipoDeComprobante
        {
            get
            {
                if (_allowBandejaPorTipoDeComprobante)
                    if (_bandejasPorTipoDeComprobante.ContainsKey(this._idTipoDeComprobante))
                        return Convert.ToString(_bandejasPorTipoDeComprobante[this._idTipoDeComprobante]);
                return null;
            }
        }
        //Fin German 20100713 - Tarea 793

		#endregion

		#region METODOS PUBLICOS

		public string Empresa
		{
			get{ return Variables.GetValueString("Sistema.NombreEmpresa");}
		}
		public string DireccionEmpresa
		{
			get{ return Variables.GetValueString("Sistema.DireccionEmpresa");}
		}
		public string TelefonoEmpresa
		{
			get{ return Variables.GetValueString("Sistema.TelefonosEmpresa");}
		}
		public string Usuario
		{
			get
			{	
				sy_UsuariosDataset.sy_UsuariosRow row = sy_Usuarios.GetByPk(Security.IdUsuario);
				return Convert.ToString(row["Nombre"]);
			}
		}

		#endregion

		#region Variables Privadas
				
		private ProcessManager _processManager;
		private string _taskName;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors(); 
		private ReportParameterCollection _parametros;
		private DataView _dataSource;
		private string _idComprobante = string.Empty;
		private string _idTipoDeComprobante;
		private string _familiaDeComprobantes;
		private ArrayList _tiposDeComprobantesPrevios = new ArrayList();

		private string _tituloReporte = string.Empty;

		private bool _allowImpresoraPorTipoDeComprobante = false;
		private Hashtable _impresorasPorTipoDeComprobante = new Hashtable();

        //German 20100713 - Tarea 793
        private bool _allowBandejaPorTipoDeComprobante = false;
        private Hashtable _bandejasPorTipoDeComprobante = new Hashtable();
        //Fin German 20100713 - Tarea 793

        public string IdComprobante
        {
            get { return _idComprobante; }
        }

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonAnterior";
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
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonSiguiente";
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
		public ArrayList TiposDeComprobantesPrevios 
		{
			get 
			{
				return _tiposDeComprobantesPrevios;
			}
		}
		private bool _hasPrintExceptions = false;
		public bool HasPrintExceptions
		{
			get { return _hasPrintExceptions; }					
		}
			

		#endregion

		#region Miembros de IDependentPersistentTask		
		public void ListenerAfterFlush(object sender)
		{
			object _tasksender = sender;
			if (((ITask)_tasksender).GetTaskName().CompareTo( this._dataFromTask ) == 0)
			{
				GetDataFromClass( sender );
			}
			else
			{
				if (_tasksender is mz.erp.businessrules.GenerateCollectionCommonTasks )
				{
					GenerateCollectionCommonTasks classcollection = (GenerateCollectionCommonTasks)sender;
					foreach( object subtask in classcollection )
					{
						if (((ITask)subtask).GetTaskName().CompareTo( this._dataFromTask ) == 0)
						{
							GetDataFromClass( subtask );
						}
					} 
				}
			}
		/*	if(this._processManager.Process.ProcessName.Equals("ProcesoConsultarStockNDiasIngresarPreOrdenDeCompra"))
			{	
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra)))
				{
					mz.erp.businessrules.comprobantes.ComprobanteDeCompra cc = (mz.erp.businessrules.comprobantes.ComprobanteDeCompra)sender;
					DataTable table = _dataSource.Table;
					table = AddColumn.AddColumnToTable(table, "Numero", cc.Numero);				
					_dataSource = table.DefaultView;
				}
			}
*/
			if(this._processManager.Process.ProcessName.Equals("ProcesoPagarCompras"))
			{
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.IngresarComprobanteDePagoCompras)))
				{
					IngresarComprobanteDePagoCompras snd = (IngresarComprobanteDePagoCompras)sender;
					string IdComprobante = snd.IdComprobante;
					string IdTipoDeRetencion = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(), "TipoDeRetencion");
					if(snd.HayRetenciones(IdTipoDeRetencion))
					{
						DataSet data = tpu_RetencionesEx.GetListEx(IdComprobante, IdTipoDeRetencion);
						DataTable table = data.Tables[0];
						string nombreEmpresa = Variables.GetValueString("Sistema.NombreEmpresa");
						table = AddColumn.AddColumnToTable(table, "NombreEmpresa", nombreEmpresa);
						string domicilioEmpresa = Variables.GetValueString("Sistema.DireccionEmpresa");
						table = AddColumn.AddColumnToTable(table, "DomicilioEmpresa", domicilioEmpresa);
						string cuitEmpresa = Variables.GetValueString("Sistema.CUITEmpresa");
						table = AddColumn.AddColumnToTable(table, "CUITEmpresa", cuitEmpresa);
						_dataSource = table.DefaultView;
					}
					else
					{
						_allowShow = false;
					}

				}

			}
			
			if(this._processManager.Process.ProcessName.Equals("ProcesoModificarPrecioProducto"))
			{
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.IngresarPrecioProducto)))
				{
					IngresarPrecioProducto snd = (IngresarPrecioProducto)sender;
					DataTable table = new DataTable("TablaResultadoProcesoModificarPrecioProducto");
					DataColumn col0 = new DataColumn("IdListaDePrecio", typeof(string) );									
					table.Columns.Add(col0);
					DataColumn col1 = new DataColumn("ListaDePrecios", typeof(string) );									
					table.Columns.Add(col1);
					DataColumn col2 = new DataColumn("Codigo", typeof(string) );									
					table.Columns.Add(col2);
					DataColumn col3 = new DataColumn("CodigoSecundario", typeof(string) );									
					table.Columns.Add(col3);
					DataColumn col4 = new DataColumn("Descripcion", typeof(string) );									
					table.Columns.Add(col4);
					DataColumn col5 = new DataColumn("PrecioCostoDirecto", typeof(decimal) );									
					table.Columns.Add(col5);
					DataColumn col6 = new DataColumn("PrecioDeCostoIndirecto", typeof(decimal) );									
					table.Columns.Add(col6);
					DataColumn col7 = new DataColumn("PrecioDeCostoRef", typeof(decimal) );									
					table.Columns.Add(col7);
					DataColumn col8 = new DataColumn("MAC", typeof(decimal) );									
					table.Columns.Add(col8);
					DataColumn col9 = new DataColumn("PrecioDeVentaNeto", typeof(decimal) );									
					table.Columns.Add(col9);
					DataColumn col10 = new DataColumn("PrecioDeVentaBruto", typeof(decimal) );									
					table.Columns.Add(col10);
					DataColumn col11 = new DataColumn("PrecioDeVentaBrutoConImpuesto", typeof(decimal) );									
					table.Columns.Add(col11);
					DataColumn col12 = new DataColumn("Coeficiente", typeof(decimal) );									
					table.Columns.Add(col12);
					DataColumn col13 = new DataColumn("MaxDescuento", typeof(decimal) );									
					table.Columns.Add(col13);
					DataColumn col14 = new DataColumn("MaxDescuentoPorcentual", typeof(decimal) );									
					table.Columns.Add(col14);

					if(snd.ListaDePreciosHabilitadas)
					{
						foreach(Producto prod in snd.Productos)
						{
							foreach(ListaDePreciosItem item in prod.ListaDePrecios.Items)
							{
								DataRow rowLP = mz.erp.businessrules.tsh_ListasDePrecios.GetByPk(item.IdListaDePrecios);
								string descLP = (string)rowLP["Descripcion"];
								DataRow row = table.NewRow();
								row["IdListaDePrecio"] = item.IdListaDePrecios;
								row["ListaDePrecios"] = descLP;
								row["Codigo"] = prod.Codigo;
								row["CodigoSecundario"] = prod.CodigoSecundario;
								row["Descripcion"] = prod.Descripcion;
								row["PrecioCostoDirecto"] = prod.PrecioDeCostoAnterior;
								row["PrecioDeCostoIndirecto"] = prod.CostosIndirectos;
								row["PrecioDeCostoRef"] = prod.PrecioDeCosto;
								row["MAC"] = prod.MAC;
								row["PrecioDeVentaNeto"] = prod.PrecioDeVentaNeto;
								tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP = tsh_ProductosListasDePrecios.GetByPk(prod.IdProducto, item.IdListaDePrecios);
								row["PrecioDeVentaBruto"] = rowPLP.PrecioDeVentaBruto;
								row["PrecioDeVentaBrutoConImpuesto"] = rowPLP.PrecioDeVentaBrutoConImpuesto;
								row["Coeficiente"] = rowPLP.Coeficiente;
								row["MaxDescuento"] = rowPLP.MaxDescuento;
								row["MaxDescuentoPorcentual"] = rowPLP.MaxDescuentoPorcentual;
								table.Rows.Add(row);
							}
							
						}
						DataView dv = table.DefaultView;
						dv.Sort = "IdListaDePrecio";
                        _dataSource = dv;
					}
					else
					{
						foreach(Producto prod in snd.Productos)
						{
							DataRow rowLP = mz.erp.businessrules.tsh_ListasDePrecios.GetByPk(prod.ListaDePrecios.GetDefaultItem().IdListaDePrecios);
							string descLP = (string)rowLP["Descripcion"];
							DataRow row = table.NewRow();
							row["ListaDePrecios"] = descLP;
							row["Codigo"] = prod.Codigo;
							row["CodigoSecundario"] = prod.CodigoSecundario;
							row["Descripcion"] = prod.Descripcion;
							//Sabrina: tarea 56
							//row["PrecioCostoDirecto"] = prod.PrecioDeCostoAnterior;
							row["PrecioDeCostoIndirecto"] = prod.CostosIndirectos;
							row["PrecioCostoDirecto"] = prod.PrecioDeCostoDirecto;
							row["PrecioDeCostoRef"] = prod.PrecioDeCosto;
							row["MAC"] = prod.MAC;
							row["PrecioDeVentaNeto"] = prod.PrecioDeVentaNeto;
							ListaDePreciosItem item = prod.ListaDePrecios.GetDefaultItem();
							row["PrecioDeVentaBruto"] = item.PrecioDeVentaBruto;
							row["PrecioDeVentaBrutoConImpuesto"] = item.PrecioDeVentaBrutoConImpuestos;
							row["Coeficiente"] = item.CoeficienteGral;
							row["MaxDescuento"] = item.MaxDescuento;
							row["MaxDescuentoPorcentual"] = item.PorcentajeMaximoDescuento;
							table.Rows.Add(row);
						}
						_dataSource = table.DefaultView;
					}
	
				}
				

			}
			if (	(_tasksender is mz.erp.businessrules.comprobantes.ComprobanteDePago) 
				&&  
				(this._processManager.Process.ProcessName.Equals("ProcesoPagar")
				|| this._processManager.Process.ProcessName.Equals("ProcesoPagoACuentaDV")
				|| this._processManager.Process.ProcessName.Equals("ProcesoDevolverPago")
				|| this._processManager.Process.ProcessName.Equals("ProcesoDevolverPagoDV")
				)
				)
					
			{
				ComprobanteDePago comp = (ComprobanteDePago) _tasksender;
				decimal Total = 0;
				string IdComprobanteDePago = null;
				foreach(DataRow row  in comp.DatasetComprobante.tsa_Comprobantes.Rows)
				{
					if(Convert.ToString(row["IdTipoDeComprobante"]).Equals(comp.TipoComprobanteDestino))
					{
						IdComprobanteDePago = Convert.ToString(row["IdComprobante"]);
						Total = Convert.ToDecimal(row["Total"]);
						break;
					}
				}
				DataTable table = mz.erp.businessrules.tsa_Comprobantes.GetComprobanteDePagoView(IdComprobanteDePago);
				
				string moneda = tfi_Monedas.GetDescripcionMoneda(comp.IdMonedaCierre);
				
				string textoNumeros = NumberToText.NumberToWords(Total, moneda);
					
				string nombreEmpresa = Variables.GetValueString("Sistema.NombreEmpresa");
				table = AddColumn.AddColumnToTable(table, "NombreEmpresa", nombreEmpresa);
				string domicilioEmpresa = Variables.GetValueString("Sistema.DireccionEmpresa");
				table = AddColumn.AddColumnToTable(table, "DomicilioEmpresa", domicilioEmpresa);
				string cuitEmpresa = Variables.GetValueString("Sistema.CUITEmpresa");
				table = AddColumn.AddColumnToTable(table, "CUITEmpresa", cuitEmpresa);
				
				
				
				foreach(DataRow row in table.Rows)
				{
					row["TextoTotal"] = textoNumeros;
				}

					
					
				_dataSource = table.DefaultView;
					
			}


		}
		public void ListenerBeforeFlush(object sender) 
		{
		}
		#endregion
		 
		#region Miembros de ITask

		public ReportParameterCollection Parameters
		{
			get
			{
				return _parametros;
			}
		}
		public DataView DataSource
		{
			get 
			{
				if(_allowCustomSort && _dataSource != null)
				{
					_dataSource.Sort = _customSort;
				}
				return _dataSource;
			}
		}
		public string FileName
		{
			get
			{
				return this._reportName+".rpx";
			}
		}

		private bool _allowShow = true;
		public bool AllowShow() 
		{
            if (_processManager.Process.ProcessName.Equals("ProcesoPrevenderVender")||
                (_processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderManual") && this.GetTaskName().Equals("ImprimirReporteB")))
				return _allowShow;
			else
				return Variables.GetValueBool(_processManager.Process.ProcessName, this.GetTaskName(), "MuestraFormulario", true);
			//return _allowShow;
		}
		public void FormHasClosed() 
		{
		}

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
			// TODO: agregar la implementación ImprimirReporte.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			/*
			if( 
				this._processManager.Process.ProcessName.Equals("ProcesoConsultarPosicionDeCaja") ||
				this._processManager.Process.ProcessName.Equals("ProcesoConsultarPosicionCaja") ||
				this._processManager.Process.ProcessName.Equals("ProcesoConsultasCobranzasYPagos")||
				this._processManager.Process.ProcessName.Equals("ProcesoConsultasMovimientosDeCaja"))
			{
				
				object _tasksender = sender;
				if (((ITask)_tasksender).GetTaskName().CompareTo( this._dataFromTask ) == 0)
				{
					GetDataFromClass( sender );
				}
				
			}
			*/

			if(this._processManager.Process.ProcessName.Equals("ProcesoConsultarValores"))
			{	
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.ConsultaValores)))
				{
					ConsultaValores cv = (ConsultaValores)sender;
					DataTable result = cv.Result;
					_dataSource = new DataView(result,"Seleccion = true", null,System.Data.DataViewRowState.CurrentRows);
					this._parametros.Clear();
					
				}	
			}
			if(this._processManager.Process.ProcessName.Equals("ProcesoConsultaOtrosComprobantes"))
			{
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.ListarComprobantes)))
				{
					ListarComprobantes cc = (ListarComprobantes)sender;
					_dataSource = cc.Result.DefaultView;
					this._parametros.Clear();
					this._parametros.Add( new ReportParameter( "FamiliaComprobantes", cc.FamiliaComprobantes));
				}
			}
			if(this._processManager.Process.ProcessName.Equals("ProcesoConsultarPresupuestosPendientesAceptacion")
				|| this._processManager.Process.ProcessName.Equals("ProcesoConsultarPresupuestosAceptadosRechazadosPendientesDeRealizacion")
				|| this._processManager.Process.ProcessName.Equals("ProcesoConsultarPresupuestosRealizadosPendientes"))
			{
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.ListarComprobantesPendientes)))
				{
					ListarComprobantesPendientes cc = (ListarComprobantesPendientes)sender;
					_dataSource = cc.Result.DefaultView;
					this._parametros.Clear();
					this._parametros.Add( new ReportParameter( "Titulo", _tituloReporte));
					
				}
			}

			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ConsultasDeCaja)))
			{
				ConsultasDeCaja cc = (ConsultasDeCaja)sender;
				_dataSource = cc.Data.Tables[0].DefaultView;
			}
			if(this._processManager.Process.ProcessName.Equals("ProcesoConsultarStockNDias"))
			{
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.StockNDias)))
				{
					StockNDias snd = (StockNDias)sender;
					DataTable aux = snd.Result.Clone();
					aux.Clear();
					foreach(DataRow row in snd.Result.Rows)
					{
						//German 20090428
						if(!row.IsNull("CantidadAComprar") && Convert.ToDecimal(row["CantidadAComprar"]) > 0)
						//Fin German 20090428
						{
							aux.ImportRow(row);
						}

					}
					_dataSource = aux.DefaultView;

				}

			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ConsultaCompras)))
			{
				ConsultaCompras cc = (ConsultaCompras)sender;
				_dataSource = cc.Result.DefaultView;
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ConsultaMovimientosStock)))
			{
				ConsultaMovimientosStock cc = (ConsultaMovimientosStock)sender;
				_dataSource = cc.Result.DefaultView;
			}
			
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta)))
			{
                if ((this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVender") && this.GetTaskName().Equals("ImprimirReporte")) ||
                    ((this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderManual") && this.GetTaskName().Equals("ImprimirReporteB"))))
                {
                    bool ActivarCertificadoDeGarantia = Variables.GetValueBool(_processManager.Process.ProcessName, this.GetTaskName(), "ActivarCertificadoDeGarantia");
                    _allowShow = false;
                    string IdTipoProductoGarantia = Variables.GetValueString("Productos.IdTipoProducto.ServicioDeGarantia");
                    if (ActivarCertificadoDeGarantia)
                    {
                        comprobantes.ComprobanteDeVenta cv = (comprobantes.ComprobanteDeVenta)sender;
                        _idComprobante = cv.IdComprobante;

                        foreach (ItemComprobante ic in cv.Items)
                        {
                            if (ic.IdTipoProducto == IdTipoProductoGarantia)
                            {
                                _allowShow = true;
                            }
                        }
                    }
                }
                else
                //German 20101207 - Tarea 919
                {
                    if ((this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVender") && this.GetTaskName().Equals("ImprimirReporteB")) ||
                    ((this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderManual") && this.GetTaskName().Equals("ImprimirReporte"))))
                    {
                        comprobantes.ComprobanteDeVenta cv1 = (comprobantes.ComprobanteDeVenta)sender;
                        Hashtable ors = cv1.Items.GetORAsociadas();
                        _allowShow = false;
                        foreach (long idor in ors.Keys)
                        {
                            DataSet data =  mz.erp.businessrules.st_OrdenReparacion.GetComentarios(idor);
                            if (data.Tables[0].Rows.Count > 0)
                            {
                                _allowShow = true;
                                break;
                            }

                        }
                        
                        
                    }
                    else
                    {
                        ArrayList ordenes = new ArrayList();
                        ArrayList comprobantesOrigen = new ArrayList();
                        string Variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + ".ActivarDetalleEquipoNuevo";
                        bool ActivarDetalleEquipoNuevo = Variables.GetValueBool(Variable);

                        comprobantes.ComprobanteDeVenta cv = (comprobantes.ComprobanteDeVenta)sender;

                        foreach (ItemComprobante ic in cv.Items)
                        {
                            if (ic.IdComprobanteOrigen != null && ic.IdComprobanteOrigen != string.Empty)
                            {
                                DataSet data = Workflow.GetCaminoComprobantesBottonUp(ic.IdComprobanteOrigen, null);
                                foreach (DataRow row in data.Tables[0].Rows)
                                {
                                    if (!_tiposDeComprobantesPrevios.Contains(row["IdTipoDeComprobante"]))
                                        _tiposDeComprobantesPrevios.Add(row["IdTipoDeComprobante"]);
                                }

                                if (!ActivarDetalleEquipoNuevo)
                                {
                                    if (!comprobantesOrigen.Contains(ic.IdComprobanteOrigen))
                                    {
                                        comprobantesOrigen.Add(ic.IdComprobanteOrigen);
                                        tsa_ComprobantesOrdenReparacionDataset.tsa_ComprobantesOrdenReparacionDataTable tabla = tsa_ComprobantesOrdenReparacion.GetList(ic.IdComprobanteOrigen, Int64.MinValue).tsa_ComprobantesOrdenReparacion;
                                        foreach (tsa_ComprobantesOrdenReparacionDataset.tsa_ComprobantesOrdenReparacionRow row in tabla.Rows)
                                        {
                                            if (!ordenes.Contains(row.IdOrdenReparacion))
                                            {
                                                ordenes.Add(row.IdOrdenReparacion);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (!ActivarDetalleEquipoNuevo)
                        {
                            if (_hasPrintExceptions == false)
                            {
                                foreach (long IdOrdenReparacion in ordenes)
                                {
                                    st_OrdenReparacionDataset.st_OrdenReparacionRow row = businessrules.st_OrdenReparacion.GetByPk(IdOrdenReparacion.ToString());
                                    if (row.EsEquipoNuevo)
                                    {
                                        _hasPrintExceptions = true;
                                    }
                                }
                            }
                        }
                    }
                }
                //Fin German 20101207 - Tarea 919
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.CuentaCorrienteGeneral)))
			{
				CuentaCorrienteGeneral ccg = (CuentaCorrienteGeneral) sender;								
				//_dataSource = ccg.TablaResultado;				
				
				DataTable aux = ccg.TablaResultado.Clone();
				aux.Clear();
				foreach(DataRow row in ccg.TablaResultado.Rows)
				{					
					if(Convert.ToBoolean(row[ccg.NombreColumnaMarca]) )
					{
						aux.ImportRow(row);
					}

				}
				_dataSource = aux.DefaultView;				
			}

			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ConsultarListasDePrecios)))
			{
				ConsultarListasDePrecios clp = (ConsultarListasDePrecios)sender;
				_dataSource = clp.Result.DefaultView;
			}
			/*if(sender.GetType().Equals(typeof(mz.erp.businessrules.ImprimirReporteComprobanteDeVenta)))
			{
				ImprimirReporteComprobanteDeVenta rep = (ImprimirReporteComprobanteDeVenta)sender;
				DataTable table = rep.DataSource;
				if (this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVender"))
				{
					bool ActivarCertificadoDeGarantia = Variables.GetValueBool(_processManager.Process.ProcessName,this.GetTaskName(),"ActivarCertificadoDeGarantia");
					_allowShow = false;
					string IdTipoProductoGarantia = Variables.GetValueString("Productos.IdTipoProducto.ServicioDeGarantia");
					if (ActivarCertificadoDeGarantia)
					{
						foreach (DataRow ic in table.Rows) 
						{
							if (ic["IdTipoProducto"].ToString() == IdTipoProductoGarantia)
							{
								_allowShow = true;	
							}
						}
					}
				}
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ImprimirReporte)))
			{
				ImprimirReporte rep = (ImprimirReporte)sender;
                _idComprobante = rep.IdComprobante;
				DataTable table = rep.DataSource.Table;
				if (this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderManual"))
				{
					bool ActivarCertificadoDeGarantia = Variables.GetValueBool(_processManager.Process.ProcessName,this.GetTaskName(),"ActivarCertificadoDeGarantia");
					_allowShow = false;
					string IdTipoProductoGarantia = Variables.GetValueString("Productos.IdTipoProducto.ServicioDeGarantia");
					if (ActivarCertificadoDeGarantia)
					{
						foreach (DataRow ic in table.Rows) 
						{
							if (ic["IdTipoProducto"].ToString() == IdTipoProductoGarantia)
							{
								_allowShow = true;	
							}
						}
					}
				}
			}*/


/*
			if(this._processManager.Process.ProcessName.Equals("ProcesoConsultarStockNDiasIngresarPreOrdenDeCompra"))
			{	
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra)))
				{
					mz.erp.businessrules.comprobantes.ComprobanteDeCompra cc = (mz.erp.businessrules.comprobantes.ComprobanteDeCompra)sender;
					DataTable table = cc.TableResultStockNDias;
					string idTipoC = cc.TipoComprobanteDestino;
					tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow rowTC = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(idTipoC);
					string nombreTipo = string.Empty;
					if(rowTC != null)
                        nombreTipo = rowTC.Descripcion;
					table = AddColumn.AddColumnToTable(table, "TipoComprobante", nombreTipo);
					table = AddColumn.AddColumnToTable(table, "Fecha", cc.FechaComprobante);
					table = AddColumn.AddColumnToTable(table, "DomicilioProveedor", cc.Proveedor.Domicilio);
					table = AddColumn.AddColumnToTable(table, "Total", cc.TotalReal);
					table = AddColumn.AddColumnToTable(table, "Moneda", cc.SimboloMonedaOrigen);
					DataColumn col = new DataColumn("PrecioReal", typeof(decimal) );						
					table.Columns.Add(col);
					int i = 0;
					foreach(ItemComprobanteCompra item in cc.Items)
				    {
						foreach(DataRow row in table.Rows)
						{
							if(row["IdProducto"] == item.IdProducto && cc.IdProveedor == row["IdProveedor"])
							{
								row["PrecioReal"] = item.PrecioDeCosto;
								break;
							}
						}
						
					}
					_dataSource =  table.DefaultView;
				}	
			}
*/
		}

		private void GetDataFromClass(object sender)
		{
			System.Type _sendertype = sender.GetType();
			this._parametros.Clear();
			foreach (string paramkey in _attributesFromTask.Keys )
			{
				object paramvalue =  _sendertype.InvokeMember(  Convert.ToString( _attributesFromTask[paramkey] ),System.Reflection.BindingFlags.GetProperty, null, sender, new object[] {} );								
				this._parametros.Add( new ReportParameter( paramkey, Convert.ToString( paramvalue ) ));
			}
            /* Silvina 20100601 - Tarea 525 */
            if (_sendertype.Name.Equals("ComprobanteDeEntrega"))
            {
                ComprobanteDeEntrega comp = (ComprobanteDeEntrega)sender;
                string orden = Variables.GetValueString("Reportes.ComprobantesEntregas.Orden");
                this._parametros.Add(new ReportParameter("@Orden", orden));
            }
            /* Fin Silvina */
			if(_configPersonalizado)
                _dataSource = mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForGenericReport( _configName, this._parametros ).DefaultView;
			else
				_dataSource = mz.erp.businessrules.reportes.StatementSQLFactory.GetSQLForGenericReport( _reportName, this._parametros ).DefaultView;


		}


		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación ImprimirReporte.ListenerBeforeExecuteDependentTask
		}

		private string _dataFromTask = string.Empty;
		private System.Collections.Hashtable _attributesFromTask = new System.Collections.Hashtable();
		private string _reportName = string.Empty;
		private bool _allowCustomSort = false;
		private string _customSort = string.Empty;

		private bool _configPersonalizado = false;
		private string _configName = string.Empty;

		/// <summary>
		/// Crea la coleccion que contendra los parametros del reporte
		/// Obtiene el nombre del reporte a imprimir, sin extensiones.
		/// Obtiene de la tarea, para el contexto determinado (proceso) a que tarea le debe capturar información.
		/// Obtiene de la tarea, para el contexto determinado (proceso) cuales son los nombres de los parámetros reales (obtenidos de la tarea previa) y formales que se usarán en el reporte.
		/// Tanto el parámetro real como el parámetro formal quedan almacenados en una coleccion denominada _attibutesFromTask
		/// </summary>
		/// <remarks>
		/// El parámetro formal (que se envia al reporte) va del lado izquierdo
		/// El parámetro real (que se obtiene de la clase) va del lado derecho
		/// </remarks>
		/// <example>
		/// Momentos.TareaImprimirA.ProcesoFacturacion.TareaPrevia = 'Vender'
		/// Momentos.TareaImprimirA.ProcesoFacturacion.Attributos = 'Cliente: IdCliente'
		/// Momentos.TareaImprimirA.ProcesoFacturacion.Reporte = 'ReporteComprobante'
		/// </example>
		/// 



		public void Init()
		{
			
			_parametros = new ReportParameterCollection();
			string VariableName = "Momentos."+this.GetTaskName()+"."+this._processManager.Process.ProcessName+".Reporte";
			string VariableData = "Momentos."+this.GetTaskName()+"."+this._processManager.Process.ProcessName+".TareaPrevia";
			string VariableAtributos = "Momentos."+this.GetTaskName()+"."+this._processManager.Process.ProcessName+".Atributos";
			string VariableConfig = "Momentos."+this.GetTaskName()+"."+this._processManager.Process.ProcessName+".UsaConfigParticular";
			_reportName = Variables.GetValueString( VariableName);
			_dataFromTask = Variables.GetValueString( VariableData);
			_configPersonalizado = Variables.GetValueBool(VariableConfig);
			if(_configPersonalizado)
                _configName = Variables.GetValueString( "Momentos."+this.GetTaskName()+"."+this._processManager.Process.ProcessName+".NombreConfig");
			string[] _attributes = Variables.GetValueString( VariableAtributos ).Split(',');
			for (int i=0;i<_attributes.Length;i++)
			{
				string[] tupla = _attributes[i].Split(':');
				if (tupla.Length == 2)
				{
					_attributesFromTask.Add( tupla[0].Trim(),tupla[1].Trim() );
				}
			}
			_allowCustomSort = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "PermiteOrdenPersonalizado");
			_customSort = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "OrdenPersonalizado");
			_tituloReporte = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "TituloReporte");

			_allowImpresoraPorTipoDeComprobante = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "UsaImpresoraPersonalizadaPorTipoDeComprobante");
			string ImpresorasPorTipoDeComprobante = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "ImpresorasPorTipoDeComprobante");
			ArrayList ImpresorasPorTipoDeComprobanteLista = mz.erp.systemframework.Util.Parse(ImpresorasPorTipoDeComprobante, ";");
			foreach(string cadena in ImpresorasPorTipoDeComprobanteLista)
			{
				string[] partes = cadena.Split(new char[]{'|'});
				if(partes.Length == 2)
					if(!_impresorasPorTipoDeComprobante.ContainsKey(partes[0]))
						_impresorasPorTipoDeComprobante.Add(partes[0], partes[1]);

			}

            //German 20100713 - Tarea 793
            _allowBandejaPorTipoDeComprobante = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "UsaBandejaPersonalizadaPorTipoDeComprobante");
            string BandejasPorTipoDeComprobante = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "BandejasPorTipoDeComprobante");
            ArrayList BandejasPorTipoDeComprobanteLista = mz.erp.systemframework.Util.Parse(BandejasPorTipoDeComprobante, ";");
            foreach (string cadena in BandejasPorTipoDeComprobanteLista)
            {
                string[] partes = cadena.Split(new char[] { '|' });
                if (partes.Length == 2)
                    if (!_bandejasPorTipoDeComprobante.ContainsKey(partes[0]))
                        _bandejasPorTipoDeComprobante.Add(partes[0], partes[1]);

            }
            //Fin German 20100713 - Tarea 793

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
			// TODO: agregar la implementación ImprimirReporte.IsValid
			return true;
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
			if (this.OnTaskBeforeExecute!=null)
			{
				OnTaskBeforeExecute(this,new System.EventArgs());
			}
			
			if (this.OnTaskAfterExecute!=null)
			{
				OnTaskAfterExecute(this,new System.EventArgs());
			}
			

		}

		#endregion
	}
}
