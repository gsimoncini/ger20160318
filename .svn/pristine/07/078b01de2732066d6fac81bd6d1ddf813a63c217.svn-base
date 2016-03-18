using System;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.commontypes;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ModificarPreciosMasivoController.
	/// </summary>
	public class ModificarPreciosMasivoController : ITaskController, IObservable, IObserver	
	{
		
		#region Constructores

		/*
		public IngresarPrecioProductoController(string CodigoProducto)
		{
			_brClass = new IngresarPrecioProducto(CodigoProducto);
			Init();
		}
		*/

		public ModificarPreciosMasivoController(ModificarPreciosMasivo brClass)
		{
			_brClass = brClass;
			Init();
		}

		#endregion

		#region Variables Privadas

		private ModificarPreciosMasivo _brClass;
		private string _leyendaFormulario;
		private string _layoutDetalle = string.Empty;
		private bool _allowEditPrecioDeCostoRef = false;
		private bool _allowRemoveItems = false;
		private bool _configuracionBasica = false;

		/*Cambios en el MAC*/

		private bool _aplicaSobreMAC = false;
		private bool _aplicaSobreMACAfectaPVP = false;
		private bool _aplicaSobreMACAfectaPVPTodos = false;
		private bool _aplicaSobreMACAfectaPVPCondicional = false;
		private bool _aplicaSobreMACAfectaPVPTodosIgualPVS = false;
		private bool _aplicaSobreMACAfectaPVPTodosTrasladaIncremento = false;
		private bool _aplicaSobreMACAfectaPVPCondicionalIgualPVS = false;
		private bool _aplicaSobreMACAfectaPVPCondicionalTrasladaIncremento = false;
		
		/*Cambios en el Precio de Costo*/
		private bool _aplicaSobreCosto = false;
		private bool _aplicaSobreCostoAfectaPVP = false;
		private bool _aplicaSobreCostoAfectaPVPTodos = false;
		private bool _aplicaSobreCostoAfectaPVPCondicional = false;
		private bool _aplicaSobreCostoAfectaPVPTodosIgualPVS = false;
		private bool _aplicaSobreCostoAfectaPVPTodosTrasladaIncremento = false;
		private bool _aplicaSobreCostoAfectaPVPCondicionalIgualPVS = false;
		private bool _aplicaSobreCostoAfectaPVPCondicionalTrasladaIncremento = false;
		private bool _aplicaSobreCostoAfectaPCRTodos = false;
		private bool _aplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion = false;

		/*Cambios en el Precio de Venta*/
		private bool _aplicaSobrePrecioDeVenta = false;
		private bool _aplicaSobrePrecioDeVentaNeto = false;
		private bool _aplicaSobrePrecioDeVentaBruto = false;
		private bool _aplicaSobrePrecioDeVentaBrutoConImpuestos = false;
		private bool _aplicaSobrePVSAfectaPVP = false;
		private bool _aplicaSobrePVSAfectaPVPTodos = false;
		private bool _aplicaSobrePVSAfectaPVPCondicional = false;
		private bool _aplicaSobrePVSAfectaPVPTodosIgualPVS = false;
		private bool _aplicaSobrePVSAfectaPVPTodosTrasladaIncremento = false;
		private bool _aplicaSobrePVSAfectaPVPCondicionalIgualPVS = false;
		private bool _aplicaSobrePVSAfectaPVPCondicionalTrasladaIncremento = false;


		/*Cambios en el porcentaje de Descuento*/
		private bool _aplicaSobreMaximoDescuentoPorcentual = false;
		private bool _aplicaSobreMaximoDescuentoPorcentualAfectaPVP = false;
		private bool _aplicaSobreMaximoDescuentoPorcentualAfectaMAC = false;



		private System.Drawing.Color _color;





		#endregion

		#region Propiedades

		public bool PrecioDeVentaAfectaMac
		{
			get{return _brClass.PrecioDeVentaAfectaMac;}
			set{_brClass.PrecioDeVentaAfectaMac = value;}
		}

		public bool PrecioDeVentaAfectaPVP
		{
			get{return _brClass.PrecioDeVentaAfectaPVP;}
			set{_brClass.PrecioDeVentaAfectaPVP = value;}
		}

		public bool HabilitaListasDePrecios
		{
			get{return _brClass.HabilitaListasDePrecios;}
		}


        //Sabrina: Tarea 834. 20101004
        /*public string IdListaDePrecioSeleccionada
        {
            get{return _brClass.IdListaDePrecioSeleccionada;}
        }*/
        //Fin Sabrina: Tarea 834. 20101004

		public ListaDePreciosItem ListaDePreciosItemSeleccionado
		{
			get{return _brClass.ListaDePreciosItemSeleccionado;}
			set{_brClass.ListaDePreciosItemSeleccionado = value;}
		}

		public decimal CoeficienteProductoLPItem
		{
			get{return _brClass.CoeficienteProductoLPItem;}
			set{_brClass.CoeficienteProductoLPItem = value;}
		}

		public decimal CoeficienteProductoMonedaRefLPItem
		{
			get{return _brClass.CoeficienteProductoMonedaRefLPItem;}
			set{_brClass.CoeficienteProductoMonedaRefLPItem = value;}
		}

		public decimal MaxDescuentoPorcentualLPItem
		{
			get{return _brClass.MaxDescuentoPorcentualLPItem;}
		}

		public decimal MaxDescuentoLPItem
		{
			get{return _brClass.MaxDescuentoLPItem;}
		}
		
		public decimal PrecioVentaBrutoLPItem
		{
			get{return _brClass.PrecioVentaBrutoLPItem;}
			set{_brClass.PrecioVentaBrutoLPItem = value;}
		}

		public decimal PrecioDeListaConImpuestoLPItem
		{
			get{return _brClass.PrecioDeListaConImpuestoLPItem;}
			set{_brClass.PrecioDeListaConImpuestoLPItem = value;}
		}
		
		public decimal PrecioFinalMonedaReferenciaLPItem
		{
			get{return _brClass.PrecioFinalMonedaReferenciaLPItem;}
			set{_brClass.PrecioFinalMonedaReferenciaLPItem = value;}
		}
		
		public decimal PrecioCostoRefLPItem
		{
			get{return _brClass.PrecioCostoRefLPItem;}
			set{_brClass.PrecioCostoRefLPItem = value;}
		}

		public decimal MACLPItem
		{
			get{return _brClass.MACLPItem;}
			set{_brClass.MACLPItem = value;}
		}

		public System.Drawing.Color Color 
		{
			get {return _color;}
		}

		public string ErrorMessage
		{
			get{return _brClass.ErrorMessage;}
		}

		public bool PermiteDeshacer
		{
			get{return _brClass.PermiteDeshacer;}
		}

		public bool AplicaSobreMaximoDescuentoPorcentual
		{
			get{return _aplicaSobreMaximoDescuentoPorcentual;}
			set
			{
				_aplicaSobreMaximoDescuentoPorcentual = value;
			}
		}
		public bool AplicaSobreMaximoDescuentoPorcentualAfectaPVP
		{
			get{return _aplicaSobreMaximoDescuentoPorcentualAfectaPVP;}
			set
			{
				_aplicaSobreMaximoDescuentoPorcentualAfectaPVP = value;
				_aplicaSobreMaximoDescuentoPorcentualAfectaMAC = !value;
			}
		}

		public bool AplicaSobreMaximoDescuentoPorcentualAfectaMAC
		{
			get{return _aplicaSobreMaximoDescuentoPorcentualAfectaMAC;}
			set
			{
				_aplicaSobreMaximoDescuentoPorcentualAfectaMAC = value;
				_aplicaSobreMaximoDescuentoPorcentualAfectaPVP = !value;
			}
		}


		public bool AplicaSobrePVSAfectaPVP
		{
			get{return _aplicaSobrePVSAfectaPVP;}
			set{_aplicaSobrePVSAfectaPVP= value;}
		}

		public bool AplicaSobrePVSAfectaPVPTodos
		{
			get{return _aplicaSobrePVSAfectaPVPTodos;}
			set{_aplicaSobrePVSAfectaPVPTodos= value;}
		}

		public bool AplicaSobrePVSAfectaPVPCondicional
		{
			get{return _aplicaSobrePVSAfectaPVPCondicional;}
			set{_aplicaSobrePVSAfectaPVPCondicional= value;}
		}


		public bool AplicaSobrePVSAfectaPVPCondicionalTrasladaIncremento
		{
			get{return _aplicaSobrePVSAfectaPVPCondicionalTrasladaIncremento;}
			set{_aplicaSobrePVSAfectaPVPCondicionalTrasladaIncremento = value;}
		}

		public bool AplicaSobrePVSAfectaPVPCondicionalIgualPVS
		{
			get{return _aplicaSobrePVSAfectaPVPCondicionalIgualPVS;}
			set{_aplicaSobrePVSAfectaPVPCondicionalIgualPVS = value;}
		}

		public bool AplicaSobrePVSAfectaPVPTodosTrasladaIncremento
		{
			get{return _aplicaSobrePVSAfectaPVPTodosTrasladaIncremento;}
			set{_aplicaSobrePVSAfectaPVPTodosTrasladaIncremento = value;}
		}

		public bool AplicaSobrePVSAfectaPVPTodosIgualPVS
		{
			get{return _aplicaSobrePVSAfectaPVPTodosIgualPVS;}
			set{_aplicaSobrePVSAfectaPVPTodosIgualPVS = value;}
		}

		public bool AplicaSobrePrecioDeVenta
		{
			get{return _aplicaSobrePrecioDeVenta;}
			set{_aplicaSobrePrecioDeVenta = value;}
		}

		public bool AplicaSobrePrecioDeVentaBruto
		{
			get{return _aplicaSobrePrecioDeVentaBruto;}
			set{_aplicaSobrePrecioDeVentaBruto = value;}
		}

		public bool AplicaSobrePrecioDeVentaBrutoConImpuestos
		{
			get{return _aplicaSobrePrecioDeVentaBrutoConImpuestos;}
			set{_aplicaSobrePrecioDeVentaBrutoConImpuestos = value;}
		}

		public bool AplicaSobrePrecioDeVentaNeto
		{
			get{return _aplicaSobrePrecioDeVentaNeto;}
			set{_aplicaSobrePrecioDeVentaNeto = value;}
		}

		public bool AplicaSobreCostoAfectaPVP
		{
			get{return _aplicaSobreCostoAfectaPVP;}
			set{_aplicaSobreCostoAfectaPVP = value;}
		}

		public bool AplicaSobreCostoAfectaPVPTodos
		{
			get{return _aplicaSobreCostoAfectaPVPTodos;}
			set{_aplicaSobreCostoAfectaPVPTodos = value;}
		}
		public bool AplicaSobreCostoAfectaPVPCondicional
		{
			get{return _aplicaSobreCostoAfectaPVPCondicional;}
			set{_aplicaSobreCostoAfectaPVPCondicional = value;}
		}
	

		public bool AplicaSobreCostoAfectaPVPCondicionalTrasladaIncremento
		{
			get{return _aplicaSobreCostoAfectaPVPCondicionalTrasladaIncremento;}
			set{_aplicaSobreCostoAfectaPVPCondicionalTrasladaIncremento = value;}
		}
	
		public bool AplicaSobreCostoAfectaPVPCondicionalIgualPVS
		{
			get{return _aplicaSobreCostoAfectaPVPCondicionalIgualPVS;}
			set{_aplicaSobreCostoAfectaPVPCondicionalIgualPVS = value;}
		}


		public bool AplicaSobreCostoAfectaPVPTodosTrasladaIncremento
		{
			get{return _aplicaSobreCostoAfectaPVPTodosTrasladaIncremento;}
			set{_aplicaSobreCostoAfectaPVPTodosTrasladaIncremento = value;}
		}

		public bool AplicaSobreCostoAfectaPVPTodosIgualPVS
		{
			get{return _aplicaSobreCostoAfectaPVPTodosIgualPVS;}
			set{_aplicaSobreCostoAfectaPVPTodosIgualPVS = value;}
		}

		public bool AplicaSobreCosto
		{
			get{return _aplicaSobreCosto;}
			set{_aplicaSobreCosto = value;}
		}

		
		public bool AplicaSobreMACAfectaPVP
		{
			get{return _aplicaSobreMACAfectaPVP;}
			set{_aplicaSobreMACAfectaPVP = value;}
		}

		public bool AplicaSobreMACAfectaPVPTodos
		{
			get{return _aplicaSobreMACAfectaPVPTodos;}
			set{_aplicaSobreMACAfectaPVPTodos = value;}
		}

		public bool AplicaSobreMACAfectaPVPCondicional
		{
			get{return _aplicaSobreMACAfectaPVPCondicional;}
			set{_aplicaSobreMACAfectaPVPCondicional = value;}
		}



		public bool AplicaSobreMACAfectaPVPCondicionalTrasladaIncremento
		{
			get{return _aplicaSobreMACAfectaPVPCondicionalTrasladaIncremento;}
			set{_aplicaSobreMACAfectaPVPCondicionalTrasladaIncremento = value;}
		}


		public bool AplicaSobreMACAfectaPVPCondicionalIgualPVS
		{
			get{return _aplicaSobreMACAfectaPVPCondicionalIgualPVS;}
			set{_aplicaSobreMACAfectaPVPCondicionalIgualPVS = value;}
		}

		public bool AplicaSobreMACAfectaPVPTodosTrasladaIncremento
		{
			get{return _aplicaSobreMACAfectaPVPTodosTrasladaIncremento;}
			set{_aplicaSobreMACAfectaPVPTodosTrasladaIncremento = value;}
		}

		
		public bool AplicaSobreMACAfectaPVPTodosIgualPVS
		{
			get{return _aplicaSobreMACAfectaPVPTodosIgualPVS;}
			set{_aplicaSobreMACAfectaPVPTodosIgualPVS = value;}
		}

		public bool AplicaSobreMAC
		{
			get{return _aplicaSobreMAC;}
			set{_aplicaSobreMAC = value;}
		}


		public bool AplicaPorcentaje
		{
			get{return _brClass.AplicaPorcentaje;}
			set{_brClass.AplicaPorcentaje = value;}
		}


		public bool AplicaValorConstante 
		{
			get{return _brClass.AplicaValorConstante;}
			set{_brClass.AplicaValorConstante = value;}
		}


		public decimal Porcentaje
		{
			get{ return _brClass.Porcentaje;}
			set{_brClass.Porcentaje = value;}
		}

		public decimal ValorConstante
		{
			get{return _brClass.ValorConstante;}
			set{_brClass.ValorConstante = value;}
		}


	

		public string IdFuenteDeCambioValorConstante
		{
			get{return _brClass.IdFuenteDeCambioValorConstante;}
			set{ _brClass.IdFuenteDeCambioValorConstante = value;}
		}

		public string IdMonedaValorConstante
		{
			get{return _brClass.IdMonedaValorConstante;}
			set{_brClass.IdMonedaValorConstante = value;}
		}

		public bool ConfiguracionBasica
		{
			get{return _configuracionBasica;}
		}

		public bool AllowRemoveItems
		{
			get{return _allowRemoveItems;}
		}
		public bool AllowEditPrecioDeCostoRef
		{
			get{return _allowEditPrecioDeCostoRef;}
		}

		public string IdFuenteDeCambioProductoPrecioDeCosto
		{
			get{return _brClass.IdFuenteDeCambioProductoPrecioDeCosto;}
		}

		
		public string SimboloMonedaDescuentoMaximo
		{
			get{return _brClass.SimboloMonedaDescuentoMaximo;}
		}

		public decimal Coeficiente1
		{
			get{return _brClass.Coeficiente1;}
		}

		public decimal Coeficiente2
		{
			get{return _brClass.Coeficiente2;}
		}
	
		/*public decimal CostoIndirecto1
		{
			get{return _brClass.CostoIndirecto1;}
		}

		public decimal CostoIndirecto2
		{
			get{return _brClass.CostoIndirecto2;}
		}

		*/
		public decimal CostosIndirectos
		{
			get{return _brClass.CostosIndirectos;}
		}

		//--- COSTOS EN MONEDA---------------------
		public decimal CostoIndirecto1
		{
			get{return _brClass.CostoIndirecto1;}
			set{_brClass.CostoIndirecto1 = value;}
		}

		public decimal CostoIndirecto2
		{
			get{return _brClass.CostoIndirecto2;}
			set{_brClass.CostoIndirecto2 = value;}
		}
		public decimal CostoIndirecto3
		{
			get{return _brClass.CostoIndirecto3;}
			set{_brClass.CostoIndirecto3 = value;}
		}

		public decimal CostoIndirecto4
		{
			get{return _brClass.CostoIndirecto4;}
			set{_brClass.CostoIndirecto4 = value;}
		}

		public decimal CostoIndirecto5
		{
			get{return _brClass.CostoIndirecto5;}
			set{_brClass.CostoIndirecto5 = value;}
		}

		public decimal CostoIndirecto6
		{
			get{return _brClass.CostoIndirecto6;}
			set{_brClass.CostoIndirecto6 = value;}
		}

		public decimal CostoIndirecto7
		{
			get{return _brClass.CostoIndirecto7;}
			set{_brClass.CostoIndirecto7 = value;}
		}
		public decimal CostoIndirecto8
		{
			get{return _brClass.CostoIndirecto8;}
			set{_brClass.CostoIndirecto8 = value;}
		}

		public decimal CostoIndirecto9
		{
			get{return _brClass.CostoIndirecto9;}
			set{_brClass.CostoIndirecto9 = value;}
		}

		public decimal CostoIndirecto10
		{
			get{return _brClass.CostoIndirecto10;}
			set{_brClass.CostoIndirecto10 = value;}
		}
		//-----------------------------------------

		//--- PROCENTAJES -------------------------
		public decimal CostoIndirectoPorc1
		{
			get{return _brClass.CostoIndirectoPorc1;}
			set{_brClass.CostoIndirectoPorc1 = value;}
		}

		public decimal CostoIndirectoPorc2
		{
			get{return _brClass.CostoIndirectoPorc2;}
			set{_brClass.CostoIndirectoPorc2 = value;}
		}
		public decimal CostoIndirectoPorc3
		{
			get{return _brClass.CostoIndirectoPorc3;}
			set{_brClass.CostoIndirectoPorc3 = value;}
		}

		public decimal CostoIndirectoPorc4
		{
			get{return _brClass.CostoIndirectoPorc4;}
			set{_brClass.CostoIndirectoPorc4 = value;}
		}

		public decimal CostoIndirectoPorc5
		{
			get{return _brClass.CostoIndirectoPorc5;}
			set{_brClass.CostoIndirectoPorc5 = value;}
		}

		public decimal CostoIndirectoPorc6
		{
			get{return _brClass.CostoIndirectoPorc6;}
			set{_brClass.CostoIndirectoPorc6 = value;}
		}

		public decimal CostoIndirectoPorc7
		{
			get{return _brClass.CostoIndirectoPorc7;}
			set{_brClass.CostoIndirectoPorc7 = value;}
		}
		public decimal CostoIndirectoPorc8
		{
			get{return _brClass.CostoIndirectoPorc8;}
			set{_brClass.CostoIndirectoPorc8 = value;}
		}

		public decimal CostoIndirectoPorc9
		{
			get{return _brClass.CostoIndirectoPorc9;}
			set{_brClass.CostoIndirectoPorc9 = value;}
		}

		public decimal CostoIndirectoPorc10
		{
			get{return _brClass.CostoIndirectoPorc10;}
			set{_brClass.CostoIndirectoPorc10 = value;}
		}
		//-----------------------------------------

		public string SimboloMonedaPrecioDeCostoReferencia
		{
			get{return _brClass.SimboloMonedaPrecioDeCostoReferencia;}
		}

		public string SimboloMonedaPrecioDeLista
		{
			get{return _brClass.SimboloMonedaPrecioDeLista;}
		}

		public string SimboloMonedaPrecioDeVentaNeto
		{
			get{return _brClass.SimboloMonedaPrecioDeVentaNeto;}
		}
		
		public string SimboloMonedaOrigen
		{
			get
			{
				return _brClass.SimboloMonedaOrigen;
			}
		}

		public string SimboloMonedaReferencia
		{
			get{return _brClass.SimboloMonedaReferencia;}
		}

		public Producto SelectedItem
		{
			get{return _brClass.SelectedItem;}
			set{_brClass.SelectedItem = value;}
		}

		public ArrayList Items
		{
			get{return this._brClass.Items;}
		}

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
		}

		public string LayoutProductos
		{
			get{return _layoutDetalle;}
		}


		public DataTable TableMonedas
		{
			get{return _brClass.TableMonedas;}
		}

		public DataTable TableFuentesDeCambio 
		{
			get{return _brClass.TableFuentesDeCambio;}
		}

		public Type ProductosSearch
		{
			get{return typeof(mz.erp.ui.controllers.tsh_Productos);}
		}
		public string IdMonedaReferencia
		{
			get{return _brClass.IdMonedaReferencia;}
		}

		public string IdFuenteDeCambioReferencia
		{
			get{return _brClass.IdFuenteDeCambioReferencia;}
		}

		public decimal StockDisponible
		{
			get{return _brClass.StockDisponible;}
		}

		public string CodigoProducto
		{
			get{return _brClass.CodigoProducto;}
			set{_brClass.CodigoProducto = value;}
		}

		public decimal PrecioCostoMonedaReferencia
		{
			get{return _brClass.PrecioCostoMonedaReferencia;}
		}


		public decimal PrecioDeCostoMonedaProducto
		{
			get{return _brClass.PrecioDeCostoMonedaProducto;}
			set{_brClass.PrecioDeCostoMonedaProducto = value;}
		}
		/*
		public decimal PrecioCostoProveedorConvertidoMonedaFuenteCambioOficial
		{
			get{return _brClass.PrecioCostoProveedorConvertidoMonedaFuenteCambioOficial;}
		}
		*/

		/*
		public decimal PrecioCostoProveedorConvertidoMonedaComprador
		{
			get{return _brClass.PrecioCostoProveedorConvertidoMonedaComprador;}
		}
		*/

		
		public decimal PrecioDeCosto
		{
			get{return _brClass.PrecioDeCosto;}
			//set{_brClass.PrecioDeCosto = value;}
		}

		public decimal Cantidad
		{
			get{return _brClass.Cantidad;}
			set{_brClass.Cantidad  = value;}
		}

		public decimal MAC
		{		
			get{return _brClass.MAC;}
			set{_brClass.MAC = value;}
			
		}

		public decimal PrecioDeVentaNeto
		{
			get{return _brClass.PrecioDeVentaNeto;}
		}

		public decimal MaximoDescuento
		{
			get{return _brClass.MaximoDescuento;}
		}

		public decimal PorcentajeMaximoDescuento
		{
			get{return _brClass.PorcentajeMaximoDescuento;}
		}

		public decimal PrecioDeVentaBruto
		{
			get{return _brClass.PrecioDeVentaBruto;}
			set 
			{
				_brClass.PrecioDeVentaBruto = value;}
		}

		public decimal PrecioCostoRef
		{
			get{return _brClass.PrecioCostoRef;}
			set
			{
				_brClass.PrecioCostoRef = value;
			}
		}

		public decimal PrecioDeListaConImpuestosMonedaReferencia
		{
			get{return _brClass.PrecioDeListaConImpuestosMonedaReferencia;}
			set{_brClass.PrecioDeListaConImpuestosMonedaReferencia = value;}
		}

		public decimal PrecioDeListaConImpuestos
		{
			get{return _brClass.PrecioDeListaConImpuestos;}
			set{_brClass.PrecioDeListaConImpuestos = value;}
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}


		public bool EnableBuscadorProducto
		{
			get
			{
                //German 20110309 - Tarea 0000038
                /*
                switch(_brClass.GetProcessManagerParent().Process.ProcessName)
                {
                    case "ProcesoConfirmarIngresoMercaderia":
                        return false;
                        break;
                    case "ProcesoConfirmarIngresoMercaderiaAnterior":
                        return false;
                        break;
                    default : return true;
                }
                 * */
                return Workflow.NOEsProcesoDeConfirmacionDePrecios(_brClass.GetProcessManagerParent().Process.ProcessName);
                //Fin German 20110309 - Tarea 0000038
			}
		}

		public bool VisibleDatosProveedor
		{
			get
			{
				switch(_brClass.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoModificarPrecioProducto":
						return false;
						break;
					default : return true;
				}
			}
		}


		public bool EnableCantidad
		{
			get
			{
                //German 20110309 - Tarea 0000038
                /*
                switch(_brClass.GetProcessManagerParent().Process.ProcessName)
                {
                    case "ProcesoConfirmarIngresoMercaderia":
                        return false;
                        break;
                    case "ProcesoConfirmarIngresoMercaderiaAnterior":
                        return false;
                        break;
                    default : return true;
                }
                 * */
                return Workflow.NOEsProcesoDeConfirmacionDePrecios(_brClass.GetProcessManagerParent().Process.ProcessName);
                //Fin German 20110309 - Tarea 0000038
			}

		}

		public bool ReadOnlyPrecioDeCostoMonedaProducto
		{
			get
			{
				switch(_brClass.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoModificarPrecioProducto":
						return false;
						break;
					default : return true;
				}
			}
		}

		public bool VisibleDatosCompra
		{
			get
			{
				switch(_brClass.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoModificarPrecioProducto":
						return !_configuracionBasica;
						break;
					default : return true;
				}
			}
		}

		public bool VisibleDatosVenta
		{
			get
			{
				switch(_brClass.GetProcessManagerParent().Process.ProcessName)
				{
					
					default : return true;
				}
			}
		}

		private bool _permiteModificarPrecioDeCostoPromedioPonderado = false;
		public bool PermiteModificarPrecioDeCostoPromedioPonderado
		{
			get{return _permiteModificarPrecioDeCostoPromedioPonderado;}			
		}

		private bool _permiteModificarPrecioDeCostoReposicion = true;
		public bool PermiteModificarPrecioDeCostoReposicion
		{
			get{return _permiteModificarPrecioDeCostoReposicion;}			
		}
		
		private bool _permiteModificarUsaPrecioDeCostoReposicion = true;
		public bool PermiteModificarUsaPrecioDeCostoReposicion
		{
			get{return _permiteModificarUsaPrecioDeCostoReposicion;}			
		}

		private bool _usaPrecioDeListaProveedor = false;
		public bool UsaPrecioDeListaProveedor
		{
			get{return _usaPrecioDeListaProveedor;}
		}

		public decimal PrecioDeCostoIndirecto
		{
			get{return _brClass.PrecioDeCostoIndirecto;}			
		}

		public decimal PrecioDeCostoReposicion
		{
			get{return _brClass.PrecioDeCostoReposicion;}			
			set{_brClass.PrecioDeCostoReposicion = value;}			
		}

		public decimal PrecioDeCostoPromedioPonderado
		{
			get{return _brClass.PrecioDeCostoPromedioPonderado;}			
			set{_brClass.PrecioDeCostoPromedioPonderado = value;}			
		}

		public bool UsaPrecioDeCostoReposicion
		{
			get{return _brClass.UsaPrecioDeCostoReposicion;}			
			set{_brClass.UsaPrecioDeCostoReposicion = value;}			
		}

		public bool AplicaSobreCostoAfectaPCRTodos
		{
			get{return _aplicaSobreCostoAfectaPCRTodos;}
			set{_aplicaSobreCostoAfectaPCRTodos = value;}
		}

		public bool AplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion
		{
			get{return _aplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion;}
			set{_aplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion = value;}
		}

		private bool _usaCostosIndirectos = false;
		public bool UsaCostosIndirectos
		{
			get{return _usaCostosIndirectos;}
		}

		//----------------------------------------- carga las descrip de los Costos Indirectos
		public string CostosIndirectosDescrip1
		{
			get{return _brClass.CostosIndirectosDescrip1;}
		}
		public string CostosIndirectosDescrip2
		{
			get{return _brClass.CostosIndirectosDescrip2;}
		}
		public string CostosIndirectosDescrip3
		{
			get{return _brClass.CostosIndirectosDescrip3;}
		}
		public string CostosIndirectosDescrip4
		{
			get{return _brClass.CostosIndirectosDescrip4;}
		}
		public string CostosIndirectosDescrip5
		{
			get{return _brClass.CostosIndirectosDescrip5;}
		}
		public string CostosIndirectosDescrip6
		{
			get{return _brClass.CostosIndirectosDescrip6;}
		}
		public string CostosIndirectosDescrip7
		{
			get{return _brClass.CostosIndirectosDescrip7;}
		}
		public string CostosIndirectosDescrip8
		{
			get{return _brClass.CostosIndirectosDescrip8;}
		}
		public string CostosIndirectosDescrip9
		{
			get{return _brClass.CostosIndirectosDescrip9;}
		}
		public string CostosIndirectosDescrip10
		{
			get{return _brClass.CostosIndirectosDescrip10;}
		}

		// -------------------------------------

		// -------------------------------------
		public bool CostoIndirectoActivo1
		{
			get {return _brClass.CostoIndirectoActivo1;}
			//set {}
		}
		public bool CostoIndirectoActivo2
		{
			get {return _brClass.CostoIndirectoActivo2;}
			//set {}
		}
		public bool CostoIndirectoActivo3
		{
			get {return _brClass.CostoIndirectoActivo3;}
			//set {}
		}
		public bool CostoIndirectoActivo4
		{
			get {return _brClass.CostoIndirectoActivo4;}
			//set {}
		}
		public bool CostoIndirectoActivo5
		{
			get {return _brClass.CostoIndirectoActivo5;}
			//set {}
		}
		public bool CostoIndirectoActivo6
		{
			get {return _brClass.CostoIndirectoActivo6;}
			//set {}
		}
		public bool CostoIndirectoActivo7
		{
			get {return _brClass.CostoIndirectoActivo7;}
			//set {}
		}
		public bool CostoIndirectoActivo8
		{
			get {return _brClass.CostoIndirectoActivo8;}
			//set {}
		}
		public bool CostoIndirectoActivo9
		{
			get {return _brClass.CostoIndirectoActivo9;}
			//set {}
		}
		public bool CostoIndirectoActivo10
		{
			get {return _brClass.CostoIndirectoActivo10;}
			//set {}
		}
		// -------------------------------------
		// ---------------- get CostosIndirectos.tipo
		public bool CostoIndirectoTipo1
		{
			get {return _brClass.CostoIndirectoTipo1;}
		}
		public bool CostoIndirectoTipo2
		{
			get {return _brClass.CostoIndirectoTipo2;}
		}
		public bool CostoIndirectoTipo3
		{
			get {return _brClass.CostoIndirectoTipo3;}
		}
		public bool CostoIndirectoTipo4
		{
			get {return _brClass.CostoIndirectoTipo4;}
		}
		public bool CostoIndirectoTipo5
		{
			get {return _brClass.CostoIndirectoTipo5;}
		}
		public bool CostoIndirectoTipo6
		{
			get {return _brClass.CostoIndirectoTipo6;}
		}
		public bool CostoIndirectoTipo7
		{
			get {return _brClass.CostoIndirectoTipo7;}
		}
		public bool CostoIndirectoTipo8
		{
			get {return _brClass.CostoIndirectoTipo8;}
		}
		public bool CostoIndirectoTipo9
		{
			get {return _brClass.CostoIndirectoTipo9;}
		}
		public bool CostoIndirectoTipo10
		{
			get {return _brClass.CostoIndirectoTipo10;}
		}
		// --------------------


        //Sabrina: Tarea 863. 20101109
        public ArrayList ListasDePrecios
        {
            get
            {
                return _brClass.ListasDePrecios;
            }
        }

        public ArrayList ListasDePreciosSeleccionadas
        {
            set
            {
                _brClass.ListasDePreciosSeleccionadas = value;
            }
        }
        //Fin Sabrina: Tarea 863. 20101109

        //Sabrina: Tarea 1068. 20110317
        public bool ActualizaPreciosProductosCombo
        {
            get { return _brClass.ActualizaPreciosProductosCombo; }
            set { _brClass.ActualizaPreciosProductosCombo = value; }
        }
        //Fin Sabrina: Tarea 1068. 20110317
        
        #endregion


		#region Eventos
			
		public event EventHandler PrecioCostoProveedorConvertidoMonedaReferenciaChanged;
		public event EventHandler PrecioCostoProveedorConvertidoMonedaFuenteCambioOficialChanged;
		public event EventHandler PrecioDeCostoChanged;
			
		public event EventHandler PrecioCostoAnteriorChanged;
		public event EventHandler StockDisponibleChanged;
		public event EventHandler ObjectHasChanged;
		public event EventHandler PrecioDeCostoRefChanged;
		public event EventHandler PrecioDeVentaBrutoChanged;
		public event EventHandler PorcentajeMaximoDescuentoChanged;
		public event EventHandler MaximoDescuentoChanged;
		public event EventHandler MACChanged;

		
		
		public event EventHandler AplicaValorConstanteChanged; 
		public event EventHandler AplicaPorcentajeChanged;
		public event EventHandler ErrorOcurred;




		public event EventHandler AplicaSobreMACChanged;
		public event EventHandler AplicaSobreMACAfectaPVPChanged;
		public event EventHandler AplicaSobreMACAfectaPVPTodosChanged;
		public event EventHandler AplicaSobreMACAfectaPVPCondicionalChanged;
		public event EventHandler AplicaSobreMACAfectaPVPTodosIgualPVSChanged;
		public event EventHandler AplicaSobreMACAfectaPVPTodosTrasladaIncrementoChanged;
		public event EventHandler AplicaSobreMACAfectaPVPCondicionalIgualPVSChanged;
		public event EventHandler AplicaSobreMACAfectaPVPCondicionalTrasladaIncrementoChanged;
		
		/*Cambios en el Precio de Costo*/
		
		public event EventHandler AplicaSobreCostoChanged;
		public event EventHandler AplicaSobreCostoAfectaPVPChanged;
		public event EventHandler AplicaSobreCostoAfectaPVPTodosChanged;
		public event EventHandler AplicaSobreCostoAfectaPVPCondicionalChanged;
		public event EventHandler AplicaSobreCostoAfectaPVPTodosIgualPVSChanged;
		public event EventHandler AplicaSobreCostoAfectaPVPTodosTrasladaIncrementoChanged;
		public event EventHandler AplicaSobreCostoAfectaPVPCondicionalIgualPVSChanged;
		public event EventHandler AplicaSobreCostoAfectaPVPCondicionalTrasladaIncrementoChanged;
		public event EventHandler AplicaSobreCostoAfectaPCRTodosChanged;
		public event EventHandler AplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicionChanged;

		/*Cambios en el Precio de Venta*/
		public event EventHandler AplicaSobrePrecioDeVentaChanged;
		public event EventHandler AplicaSobrePrecioDeVentaNetoChanged;
		public event EventHandler AplicaSobrePrecioDeVentaBrutoChanged;
		public event EventHandler AplicaSobrePrecioDeVentaBrutoConImpuestosChanged;
		public event EventHandler AplicaSobrePVSAfectaPVPChanged;
		public event EventHandler AplicaSobrePVSAfectaPVPTodosChanged;
		public event EventHandler AplicaSobrePVSAfectaPVPCondicionalChanged;
		public event EventHandler AplicaSobrePVSAfectaPVPTodosIgualPVSChanged;
		public event EventHandler AplicaSobrePVSAfectaPVPTodosTrasladaIncrementoChanged;
		public event EventHandler AplicaSobrePVSAfectaPVPCondicionalIgualPVSChanged;
		public event EventHandler AplicaSobrePVSAfectaPVPCondicionalTrasladaIncrementoChanged;



		public event EventHandler AplicaSobreMaximoDescuentoPorcentualChanged;

		public event EventHandler ProductosCollectionBackChanged;

		#endregion

		#region Metodos Privados

		private void _brClass_ProductosCollectionChanged(object sender, EventArgs e)
		{
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());
		}


		private void Refresh(object sender, EventArgs e)
		{
			
			if(ValorCotizacionFuenteDeCambioCompradorChanged != null)
				ValorCotizacionFuenteDeCambioCompradorChanged(this, new EventArgs());
			if(PrecioDeCostoRefChanged != null)
				PrecioDeCostoRefChanged(this, new EventArgs());
			if(PrecioDeVentaBrutoChanged != null)
				PrecioDeVentaBrutoChanged(this, new EventArgs());
			if(PorcentajeMaximoDescuentoChanged != null)
				PorcentajeMaximoDescuentoChanged(this, new EventArgs());
			if(MaximoDescuentoChanged != null)
				MaximoDescuentoChanged(this, new EventArgs());
			if(MACChanged != null)
				MACChanged(this, new EventArgs());
			if(PrecioCostoProveedorConvertidoMonedaReferenciaChanged != null)
				PrecioCostoProveedorConvertidoMonedaReferenciaChanged(this, new EventArgs());
			if(PrecioCostoProveedorConvertidoMonedaFuenteCambioOficialChanged != null)
				PrecioCostoProveedorConvertidoMonedaFuenteCambioOficialChanged(this, new EventArgs());
			if(PrecioDeCostoChanged != null)
				PrecioDeCostoChanged(this, new EventArgs());
			if(PrecioCostoAnteriorChanged != null)
				PrecioCostoAnteriorChanged(this, new EventArgs());
			if(StockDisponibleChanged != null)
				StockDisponibleChanged(this, new EventArgs());
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		
		}
		
		private void SetLayoutDetalle()
		{
			
			ArrayList _buildedarray = new ArrayList();
			switch (this._brClass.GetProcessManagerParent().Process.ProcessName)
			{
				
				case "ProcesoModificarPreciosMasivo":
				{
					_buildedarray.Add("Codigo");
					_buildedarray.Add("Descripcion");
					_buildedarray.Add("SimboloMonedaOrigen");
					_buildedarray.Add("PrecioDeCosto");
					_buildedarray.Add("MAC");
					_buildedarray.Add("SimboloMonedaPrecioDeVentaNeto");
					_buildedarray.Add("PrecioDeVentaNeto");
					_buildedarray.Add("SimboloMonedaDescuentoMaximo");
					_buildedarray.Add("MaximoDescuento");
					_buildedarray.Add("PorcentajeMaximoDescuento");
					_buildedarray.Add("SimboloMonedaPrecioDeLista");
					_buildedarray.Add("PrecioLista");
					_buildedarray.Add("PrecioDeListaConImpuestos");
					_buildedarray.Add("UsaPrecioDeCostoReposicion");
					string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;			
					_layoutDetalle = this.GetLayoutDetalle( _campos );
				}
					break;

			}
			
		}

		public string GetLayoutDetalle( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if (_fieldList != null )
			{
				fl.AddRange( _fieldList );
			}
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Cod.", 50 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 350 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "SimboloMonedaOrigen") || _fieldList == null) sb.Append( LayoutBuilder.GetRow( i++, "SimboloMonedaOrigen"," ",30));
			if ( fl.Contains( "PrecioDeCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCosto", "Costo", 60 ,Types.Aligment.Far,Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "MAC" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MAC", "MAC", 50,Types.Aligment.Far,Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "SimboloMonedaPrecioDeVentaNeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloMonedaPrecioDeVentaNeto", " ", 30,Types.EditType.NoEdit ) );
			if ( fl.Contains( "PrecioDeVentaNeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaNeto", "PVS", 60,Types.Aligment.Far,Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "SimboloMonedaDescuentoMaximo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloMonedaDescuentoMaximo", " ",30 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "MaximoDescuento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MaximoDescuento", "Desc.",50,Types.Aligment.Far,Types.FormatDisplay.Money,Types.EditType.NoEdit) );	
			if ( fl.Contains( "PorcentajeMaximoDescuento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PorcentajeMaximoDescuento", "Desc. %",50,Types.Aligment.Far,Types.FormatDisplay.Money,Types.EditType.NoEdit) );	
			if ( fl.Contains( "SimboloMonedaPrecioDeLista" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloMonedaPrecioDeLista", " ",30 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "PrecioLista" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioLista", "PVP", 60 ,Types.Aligment.Far,Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "PrecioDeListaConImpuestos") || _fieldList == null) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeListaConImpuestos","PVP con Imp.",60,Types.Aligment.Far,Types.FormatDisplay.Money,Types.EditType.NoEdit));
			if ( fl.Contains( "UsaPrecioDeCostoReposicion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UsaPrecioDeCostoReposicion", "Usa Pcio Costo Reposicion",50,Types.ColumnTypes.CheckBox,Types.EditType.NoEdit ) );

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}


		private void Init()
		{
			_allowEditPrecioDeCostoRef = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowEditPrecioDeCostoRef");
			_allowRemoveItems = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowRemoveItems");
			_configuracionBasica = Variables.GetValueBool("Productos.Precios.ConfiguracionBasica");
			string colorStr = Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "GrillaProductos.Condicion.Color");
			if(colorStr.Equals(string.Empty))
					colorStr = "Red";
			_color = System.Drawing.Color.FromName(colorStr);
			_permiteModificarPrecioDeCostoPromedioPonderado = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"PermiteModificarPrecioDeCostoPromedioPonderado", _permiteModificarPrecioDeCostoPromedioPonderado);
			_permiteModificarPrecioDeCostoReposicion = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"PermiteModificarPrecioDeCostoReposicion", _permiteModificarPrecioDeCostoReposicion);
			_permiteModificarUsaPrecioDeCostoReposicion = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"PermiteModificarUsaPrecioDeCostoReposicion", _permiteModificarUsaPrecioDeCostoReposicion);
			_usaPrecioDeListaProveedor = Variables.GetValueBool("Productos.Compras.Facturas.UsaPrecioDeListaProveedor");
			_usaCostosIndirectos = Variables.GetValueBool("Productos.PrecioDeCosto.UsaCostosIndirectos", _usaCostosIndirectos);
			InitEventHandlers();
			InitData();
		}

		private void InitData()
		{
			SetLeyendaFormulario();
			SetLayoutDetalle();

		}

		private void InitEventHandlers()
		{
			_brClass.ObjectHasChanged +=new EventHandler(Refresh);
			_brClass.ProductosCollectionChanged += new EventHandler(_brClass_ProductosCollectionChanged);
			_brClass.ErrorOcurred +=new EventHandler(_brClass_ErrorOcurred);
			_brClass.ProductosCollectionBackChanged +=new EventHandler(_brClass_ProductosCollectionBackChanged);
			
			// manejadores de eventos de los Costos Indirectos (Moneda, $)
			_brClass.CostoIndirecto1Changed += new EventHandler(_brClass_CostoIndirecto1Changed);
			_brClass.CostoIndirecto2Changed += new EventHandler(_brClass_CostoIndirecto2Changed);
			_brClass.CostoIndirecto3Changed += new EventHandler(_brClass_CostoIndirecto3Changed);
			_brClass.CostoIndirecto4Changed += new EventHandler(_brClass_CostoIndirecto4Changed);
			_brClass.CostoIndirecto5Changed += new EventHandler(_brClass_CostoIndirecto5Changed);
			_brClass.CostoIndirecto6Changed += new EventHandler(_brClass_CostoIndirecto6Changed);
			_brClass.CostoIndirecto7Changed += new EventHandler(_brClass_CostoIndirecto7Changed);
			_brClass.CostoIndirecto8Changed += new EventHandler(_brClass_CostoIndirecto8Changed);
			_brClass.CostoIndirecto9Changed += new EventHandler(_brClass_CostoIndirecto9Changed);
			_brClass.CostoIndirecto10Changed += new EventHandler(_brClass_CostoIndirecto10Changed);
			
			// manejadores de eventos de los Costos Indirectos (Procentaje, %)
			_brClass.CostoIndirectoPorc1Changed += new EventHandler(_brClass_CostoIndirectoPorc1Changed);
			_brClass.CostoIndirectoPorc2Changed += new EventHandler(_brClass_CostoIndirectoPorc2Changed);
			_brClass.CostoIndirectoPorc3Changed += new EventHandler(_brClass_CostoIndirectoPorc3Changed);
			_brClass.CostoIndirectoPorc4Changed += new EventHandler(_brClass_CostoIndirectoPorc4Changed);
			_brClass.CostoIndirectoPorc5Changed += new EventHandler(_brClass_CostoIndirectoPorc5Changed);
			_brClass.CostoIndirectoPorc6Changed += new EventHandler(_brClass_CostoIndirectoPorc6Changed);
			_brClass.CostoIndirectoPorc7Changed += new EventHandler(_brClass_CostoIndirectoPorc7Changed);
			_brClass.CostoIndirectoPorc8Changed += new EventHandler(_brClass_CostoIndirectoPorc8Changed);
			_brClass.CostoIndirectoPorc9Changed += new EventHandler(_brClass_CostoIndirectoPorc9Changed);
			_brClass.CostoIndirectoPorc10Changed += new EventHandler(_brClass_CostoIndirectoPorc10Changed);

		}

		private void RefreshPrecioDeCostoProveedor(object sender, EventArgs e)
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}



		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}


		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());
		}

		private ProcessControllerManager _processManager;
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}



		public ITask GetTask()
		{
			return _brClass;
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}
		
		
		public ItemsDatasetErrors GetErrors()
		{
			return 	_brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return 	_brClass.GetWarnings();
		}
		public void Continue()
		{
			_brClass.Execute();
		}

		#endregion

		#region Eventos

		public event EventHandler ValorCotizacionFuenteDeCambioCompradorChanged;
		public event EventHandler ProductosCollectionChanged;
			

		#endregion

		#region Miembros de IObservable

		private ArrayList _observers = new ArrayList();

		public void ProcessObjectsObserver()
		{
			
		}

		public void AddObjectListener(IObserver observer)
		{
			_observers.Add(observer);
		}

		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{
				ProcessItem( (ArrayList)valores);
			}
		}

		private void ProcessItem( ArrayList lista )
		{
			_brClass.AddRange(lista);		
		}

		#endregion
		
		#region Metodos Publicos

        //Sabrina: Tarea 1068. 20110317
        public bool CambioCostoProductosCombo()
        {
            return _brClass.CambioCostoProductosCombo();
        }

        public bool CambioPrecioVentaProductosCombo()
        {
            return _brClass.CambioPrecioVentaProductosCombo();
        }
        //Fin Sabrina: Tarea 1068. 20110317
        
        public void CargarCostosIndirectosDescripcion()
		{
			_brClass.CargarCostosIndirectosDescripcion();
		}

		public bool CoeficienteBinding(long indice)
		{
			return _brClass.CoeficienteBinding(indice);
		}

		public void DisconnectCostosIndirectosEvent()
		{
			
			_brClass.CostoIndirecto1ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto1ActivatedChanged);
			_brClass.CostoIndirecto2ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto2ActivatedChanged);
			_brClass.CostoIndirecto3ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto3ActivatedChanged);
			_brClass.CostoIndirecto4ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto4ActivatedChanged);
			_brClass.CostoIndirecto5ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto5ActivatedChanged);

			/*
			_brClass.CostoIndirecto1Changed -= new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc1Changed -= new EventHandler(Refresh2);
			_brClass.CostoIndirecto2Changed -= new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc2Changed -= new EventHandler(Refresh2);
			_brClass.CostoIndirecto3Changed -= new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc3Changed -= new EventHandler(Refresh2);
			_brClass.CostoIndirecto4Changed -= new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc4Changed -= new EventHandler(Refresh2);
			_brClass.CostoIndirecto5Changed -= new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc5Changed -= new EventHandler(Refresh2);
			*/
		}

		public void ConnectCostosIndirectosEvent()
		{
			
			_brClass.CostoIndirecto1ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto1ActivatedChanged);
			_brClass.CostoIndirecto2ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto2ActivatedChanged);
			_brClass.CostoIndirecto3ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto3ActivatedChanged);
			_brClass.CostoIndirecto4ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto4ActivatedChanged);
			_brClass.CostoIndirecto5ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto5ActivatedChanged);


			/*
			_brClass.CostoIndirecto1Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc1Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirecto2Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc2Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirecto3Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc3Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirecto4Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc4Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirecto5Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc5Changed += new EventHandler(Refresh2);
			*/
		}

		//----------------------------------------- Activa/Desactiva un Costo Indirecto
		public void ActivarCostoIndirecto(long idCosto, bool valor)
		{
			_brClass.ActivarCostoIndirecto(idCosto, valor);				
		}

		public bool CoeficienteCreadoyActivo(long indice)
		{
			return _brClass.CoeficienteCreadoyActivo(indice);				
		}
		//----------------------------------------- 


		public void UpdateCoeficienteToGral()
		{
			_brClass.UpdateCoeficienteToGral();
		}


		public void DeshacerActualizacion()
		{
			
			

			_brClass.DeshacerActualizacion();
		}

	
		public string ActualizarPrecios()
		{
			#region MAC
			_brClass.AplicaSobreMAC = _aplicaSobreMAC;
			if(!_aplicaSobreMACAfectaPVP) _brClass.AplicaSobreMACAfecta = ModificarPreciosMasivo.Afecta.NoAfecta;
			if(_aplicaSobreMAC && _aplicaSobreMACAfectaPVP && _aplicaSobreMACAfectaPVPTodos )
			{
				if(_aplicaSobreMACAfectaPVPTodosIgualPVS) _brClass.AplicaSobreMACAfecta = ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugerido;
				if(_aplicaSobreMACAfectaPVPTodosTrasladaIncremento) _brClass.AplicaSobreMACAfecta = ModificarPreciosMasivo.Afecta.PrecioDeLista;
			}
			if(_aplicaSobreMAC && _aplicaSobreMACAfectaPVP && _aplicaSobreMACAfectaPVPCondicional)
			{
				if(_aplicaSobreMACAfectaPVPCondicionalIgualPVS)_brClass.AplicaSobreMACAfecta = ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido;
				if(_aplicaSobreMACAfectaPVPCondicionalTrasladaIncremento)_brClass.AplicaSobreMACAfecta = ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido;
			}
			#endregion
			
			#region Precio de Venta
			_brClass.AplicaSobrePrecioDeVenta =  _aplicaSobrePrecioDeVenta;
			_brClass.AplicaSobrePrecioDeVentaBruto = _aplicaSobrePrecioDeVentaBruto && _aplicaSobrePrecioDeVenta;
			_brClass.AplicaSobrePrecioDeVentaBrutoConImpuestos = _aplicaSobrePrecioDeVentaBrutoConImpuestos && _aplicaSobrePrecioDeVenta;
			_brClass.AplicaSobrePrecioDeVentaNeto = _aplicaSobrePrecioDeVentaNeto && _aplicaSobrePrecioDeVenta;
			if(!_aplicaSobrePVSAfectaPVP)_brClass.AplicaSobrePrecioDeVentaAfecta = ModificarPreciosMasivo.Afecta.NoAfecta;
			if(_aplicaSobrePrecioDeVenta && _aplicaSobrePrecioDeVentaNeto && _aplicaSobrePVSAfectaPVP && _aplicaSobrePVSAfectaPVPCondicional)
			{
				if(_aplicaSobrePVSAfectaPVPCondicionalIgualPVS) _brClass.AplicaSobrePrecioDeVentaAfecta = ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido;
				if(_aplicaSobrePVSAfectaPVPCondicionalTrasladaIncremento) _brClass.AplicaSobrePrecioDeVentaAfecta = ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido;
			}
			if(_aplicaSobrePrecioDeVenta && _aplicaSobrePrecioDeVentaNeto && _aplicaSobrePVSAfectaPVP && _aplicaSobrePVSAfectaPVPTodos)
			{
				if(_aplicaSobrePVSAfectaPVPTodosIgualPVS) _brClass.AplicaSobrePrecioDeVentaAfecta = ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugerido;
				if(_aplicaSobrePVSAfectaPVPTodosTrasladaIncremento) _brClass.AplicaSobrePrecioDeVentaAfecta = ModificarPreciosMasivo.Afecta.PrecioDeLista;
			}
			#endregion

			#region Precio de Costo
			_brClass.AplicaSobrePrecioDeCosto = _aplicaSobreCosto;
			if(!_aplicaSobreCostoAfectaPVP)_brClass.AplicaSobrePrecioDeCostoAfecta = ModificarPreciosMasivo.Afecta.NoAfecta;
			if(_aplicaSobreCosto && _aplicaSobreCostoAfectaPVP && _aplicaSobreCostoAfectaPVPCondicional)
			{
				if(_aplicaSobreCostoAfectaPVPCondicionalIgualPVS) _brClass.AplicaSobrePrecioDeCostoAfecta = ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido;
				if(_aplicaSobreCostoAfectaPVPCondicionalTrasladaIncremento) _brClass.AplicaSobrePrecioDeCostoAfecta = ModificarPreciosMasivo.Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido;
			}
			if(_aplicaSobreCosto && _aplicaSobreCostoAfectaPVP && _aplicaSobreCostoAfectaPVPTodos)
			{
				if(_aplicaSobreCostoAfectaPVPTodosIgualPVS) _brClass.AplicaSobrePrecioDeCostoAfecta = ModificarPreciosMasivo.Afecta.PrecioDeListaIgualPrecioDeVentaSugerido;
				if(_aplicaSobreCostoAfectaPVPTodosTrasladaIncremento) _brClass.AplicaSobrePrecioDeCostoAfecta = ModificarPreciosMasivo.Afecta.PrecioDeLista;

			}
			_brClass.AplicaSobreCostoAfectaPCRTodos = _aplicaSobreCostoAfectaPCRTodos;
			_brClass.AplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion = _aplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion;
				
			#endregion

			#region Maximo Descuento Porcentual
				
				_brClass.AplicaSobreMaximoDescuentoPorcentual = _aplicaSobreMaximoDescuentoPorcentual;
				if(_aplicaSobreMaximoDescuentoPorcentual && _aplicaSobreMaximoDescuentoPorcentualAfectaMAC)
					_brClass.AplicaSobreMaximoDescuentoPorcentualAfecta = ModificarPreciosMasivo.Afecta.MAC;
				if(_aplicaSobreMaximoDescuentoPorcentual && _aplicaSobreMaximoDescuentoPorcentualAfectaPVP)
					_brClass.AplicaSobreMaximoDescuentoPorcentualAfecta = ModificarPreciosMasivo.Afecta.PrecioDeLista;

			#endregion

			

			return _brClass.ActualizarPrecios();
		}

		public void DeleteSelectedItem()
		{
			_brClass.DeleteSelectedItem();
		}
		
		#endregion

		private void _brClass_ErrorOcurred(object sender, EventArgs e)
		{
			if(ErrorOcurred != null)
				ErrorOcurred(this, new EventArgs());
		}

		private void _brClass_ProductosCollectionBackChanged(object sender, EventArgs e)
		{
			if(ProductosCollectionBackChanged != null)
				ProductosCollectionBackChanged(this, new EventArgs());
		}
		#region Codigo Nuevo


		public bool PorProducto
		{
			set{_brClass.PorProducto = value;}
		}

		public bool ByJerarquia1
		{
			get{return _brClass.ByJerarquia1;}
			set{_brClass.ByJerarquia1 = value;}
		}

		public bool ByJerarquia2
		{
			get{return _brClass.ByJerarquia2;}
			set{_brClass.ByJerarquia2 = value;}
		}

		public bool ByJerarquia3
		{
			get{return _brClass.ByJerarquia3;}
			set{_brClass.ByJerarquia3 = value;}
		}

		public bool ByJerarquia4
		{
			get{return _brClass.ByJerarquia4;}
			set{_brClass.ByJerarquia4 = value;}
		}

		public bool ByJerarquia5
		{
			get{return _brClass.ByJerarquia5;}
			set{_brClass.ByJerarquia5 = value;}
		}

		public bool ByJerarquia6
		{
			get{return _brClass.ByJerarquia6;}
			set{_brClass.ByJerarquia6 = value;}
		}

		public bool ByJerarquia7
		{
			get{return _brClass.ByJerarquia7;}
			set{_brClass.ByJerarquia7 = value;}
		}

		public bool ByJerarquia8
		{
			get{return _brClass.ByJerarquia8;}
			set{_brClass.ByJerarquia8 = value;}
		}

		/*public bool Resumido
		{
			get{return _brClass.Resumido;}
			set{_brClass.Resumido = value;}
		}*/

		public ArrayList Jerarquias1
		{
			get{return _brClass.Jerarquias1;}
			set{_brClass.Jerarquias1 = value;}
		}

		public ArrayList Jerarquias2
		{
			get{return _brClass.Jerarquias2;}
			set{_brClass.Jerarquias2 = value;}
		}
		public ArrayList Jerarquias3
		{
			get{return _brClass.Jerarquias3;}
			set{_brClass.Jerarquias3 = value;}
		}

		public ArrayList Jerarquias4
		{
			get{return _brClass.Jerarquias4;}
			set{_brClass.Jerarquias4 = value;}
		}

		public ArrayList Jerarquias5
		{
			get{return _brClass.Jerarquias5;}
			set{_brClass.Jerarquias5 = value;}
		}

		public ArrayList Jerarquias6
		{
			get{return _brClass.Jerarquias6;}
			set{_brClass.Jerarquias6 = value;}
		}

		public ArrayList Jerarquias7
		{
			get{return _brClass.Jerarquias7;}
			set{_brClass.Jerarquias7 = value;}
		}

		public ArrayList Jerarquias8
		{
			get{return _brClass.Jerarquias8;}
			set{_brClass.Jerarquias8 = value;}
		}	
	
		
		#endregion

		/// <summary>
		/// manejadores de Costos Indirectos (para la Moneda $)
		/// </summary>
		public event EventHandler CostoIndirecto1Changed;
		public event EventHandler CostoIndirecto2Changed;
		public event EventHandler CostoIndirecto3Changed;
		public event EventHandler CostoIndirecto4Changed;
		public event EventHandler CostoIndirecto5Changed;
		public event EventHandler CostoIndirecto6Changed;
		public event EventHandler CostoIndirecto7Changed;
		public event EventHandler CostoIndirecto8Changed;
		public event EventHandler CostoIndirecto9Changed;
		public event EventHandler CostoIndirecto10Changed;
		/// <summary>
		/// manejadores de Costos Indirectos (para el Porcentaje %)
		/// </summary>
		public event EventHandler CostoIndirectoPorc1Changed;
		public event EventHandler CostoIndirectoPorc2Changed;
		public event EventHandler CostoIndirectoPorc3Changed;
		public event EventHandler CostoIndirectoPorc4Changed;
		public event EventHandler CostoIndirectoPorc5Changed;
		public event EventHandler CostoIndirectoPorc6Changed;
		public event EventHandler CostoIndirectoPorc7Changed;
		public event EventHandler CostoIndirectoPorc8Changed;
		public event EventHandler CostoIndirectoPorc9Changed;
		public event EventHandler CostoIndirectoPorc10Changed;

		private void _brClass_CostoIndirecto1Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto1Changed != null)
				CostoIndirecto1Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto2Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto2Changed != null)
				CostoIndirecto2Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto3Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto3Changed != null)
				CostoIndirecto3Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto4Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto4Changed != null)
				CostoIndirecto4Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto5Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto5Changed != null)
				CostoIndirecto5Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto6Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto6Changed != null)
				CostoIndirecto6Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto7Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto7Changed != null)
				CostoIndirecto7Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto8Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto8Changed != null)
				CostoIndirecto8Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto9Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto9Changed != null)
				CostoIndirecto9Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto10Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto10Changed != null)
				CostoIndirecto10Changed(this, new EventArgs());
		}

		private void _brClass_CostoIndirecto1ActivatedChanged(object sender, EventArgs e)
		{
			Refresh(sender, e);
			_brClass_CostoIndirecto1Changed(sender, e);
			_brClass_CostoIndirectoPorc1Changed(sender, e);
		}

		private void _brClass_CostoIndirectoPorc1Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc1Changed != null)
				CostoIndirectoPorc1Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc2Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc2Changed != null)
				CostoIndirectoPorc2Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc3Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc3Changed != null)
				CostoIndirectoPorc3Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc4Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc4Changed != null)
				CostoIndirectoPorc4Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc5Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc5Changed != null)
				CostoIndirectoPorc5Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc6Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc6Changed != null)
				CostoIndirectoPorc6Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc7Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc7Changed != null)
				CostoIndirectoPorc7Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc8Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc8Changed != null)
				CostoIndirectoPorc8Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc9Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc9Changed != null)
				CostoIndirectoPorc9Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc10Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc10Changed != null)
				CostoIndirectoPorc10Changed(this, new EventArgs());
		}


		private void _brClass_CostoIndirecto2ActivatedChanged(object sender, EventArgs e)
		{
			Refresh(sender, e);
			_brClass_CostoIndirecto2Changed(sender, e);
			_brClass_CostoIndirectoPorc2Changed(sender, e);
		}

		private void _brClass_CostoIndirecto3ActivatedChanged(object sender, EventArgs e)
		{
			Refresh(sender, e);
			_brClass_CostoIndirecto1Changed(sender, e);
			_brClass_CostoIndirectoPorc3Changed(sender, e);
		}

		private void _brClass_CostoIndirecto4ActivatedChanged(object sender, EventArgs e)
		{
			Refresh(sender, e);
			_brClass_CostoIndirecto4Changed(sender, e);
			_brClass_CostoIndirectoPorc4Changed(sender, e);
		}

		private void _brClass_CostoIndirecto5ActivatedChanged(object sender, EventArgs e)
		{
			Refresh(sender, e);
			_brClass_CostoIndirecto5Changed(sender, e);
			_brClass_CostoIndirectoPorc5Changed(sender, e);
		}

	}
}

