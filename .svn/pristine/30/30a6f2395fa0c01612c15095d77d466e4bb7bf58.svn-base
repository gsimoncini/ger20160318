
using System;
using System.Collections;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;
using mz.erp.commontypes.data;
using System.Data;

/// <summary>
/// Clase de Servicios Estaticos. 
/// Define reglas a aplicar a las clases que intervienen en el comportamiento del comprobante. 
/// Por lo general hace uso de variables de sistemas. Si estan definidas y establece valores
/// por default en caso de que no estén implementadas.
/// </summary>
public class ComprobantesRules
{
	public ComprobantesRules()
	{
		//
		// TODO: agregar aquí la lógica del constructor
		//
	}

	/// <summary>
	/// Cantidad maxima de items que deberia aceptar el comprobante de venta.
	/// Por lo general esta limitación esta determinada por el hardware que se utiliza para emitir
	/// los comprobantes o bien por limitaciones de los reportes definidos.
	/// </summary>
	/// <returns></returns>
	public static long GetMaxItemValue()
	{
		object value = mz.erp.businessrules.Variables.GetValue("Comprobante.Factura.Maxima.Cantidad.Items");
		if (value != null) 
		{	return (long)value;}
		else
		{	return (long)999999.99;}

	}


	public static string Comprobantes_IdComprobanteDePagoAsociado
	{
		get
		{
			return Variables.GetValueString("Comprobantes.Variables.IdComprobanteDePagoAsociado");
		}

	}

	public static bool Comprobantes_Seguridad_Productos_Permite_ModificarDescripcion
	{
		get
		{
			return Variables.GetValueBool("Comprobante.Seguridad.Productos.PermiteModificarDescripcion");
		}
	}

	public static string Comprobantes_Productos_AgrupaProductos
	{
		get
		{
			return Variables.GetValueString("Comprobantes.Productos.AgrupaProductos");
		}
	}

	public static string Comprobantes_Bonificaciones_Metodo
	{
		get
		{
			return Variables.GetValueString("Comprobantes.Bonificaciones.Metodo");
		}
	}

	public static string Contabilidad_FuenteDeCambioReferencia
	{
		get
		{
			return Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
		}
	}
	
	public static string Contabilidad_CotizacionReferencia
	{
		get
		{
			return Variables.GetValueString("Contabilidad.CotizacionReferencia");
		}
	}
	public static string Contabilidad_MonedaReferencia
	{
		get
		{
			return Variables.GetValueString("Contabilidad.MonedaReferencia");
		}
	}
	
	public static long Comprobantes_MomentosDeStock( string unTipo)
	{
		return Variables.GetValueLong( "Comprobantes.MomentosDeStock."+ unTipo );
	}
	public static string Comprobantes_Variables_IdBonificacionCuenta
	{
		get
		{
			return Variables.GetValueString( "Comprobantes.Variables.IdBonificacionCuenta");
		}
	}
	public static string Comprobantes_Variables_IdCondicionDeVenta
	{
		get
		{
			return Variables.GetValueString( "Comprobantes.Variables.IdCondicionDeVenta");
		}
	}

	//German 20100428 - Tarea 741
	public static bool Momentos_MuestraRecargoCodicionDeVentaEnTituloPantallaSeleccionarFormaDePago(string ProcessName, string TaskName)
	{
		bool ok = Variables.GetValueBool(ProcessName, TaskName, "MuestraPorcentajeCondicionDeVentaEnTituloVentana");
		return ok;
	}
	//Fin German 20100428

	public static string[] Comprobantes_Admitidos_Segun_Momento( string procesName, string taskName )
	{
		string valores = ComprobantesRules.Momentos_Parametros(	procesName, taskName,"Comprobantes");
		return valores.Split(new char[] { Convert.ToChar( "," ) }, 50 );
	}


	public static string[] Comprobantes_Admitidos_Segun_Momento( string unMomento )
	{
		string valores = Variables.GetValueString( "Momentos."+unMomento+".Comprobantes");
		return valores.Split(new char[] { Convert.ToChar( "," ) }, 50 );
	}

	/*
		string valores = Variables.GetValueString( "CategoriaImpositiva.Comprobantes."+unTipo );
		if (valores == string.Empty)
		{
			valores = Variables.GetValueString( "CategoriaImpositiva.Comprobantes.Default" );
		}
		return valores.Split( new char[] { Convert.ToChar( "," )}, 50 );
		*/
		
	


	private static Hashtable _categoriaImpositivaTiposDeComprobantes = new Hashtable();

	public static void Reset()
	{
		_categoriaImpositivaTiposDeComprobantes.Clear();
	}
	
	public static ArrayList CategoriaImpositiva_Comprobantes_Por_Tipo( string unTipo )
	{
		if(_categoriaImpositivaTiposDeComprobantes.Count == 0)
		{
			DataSet data = mz.erp.businessrules.tsy_TiposDeComprobantesCategoriaIva.GetList();
			foreach(DataRow row in data.Tables[0].Rows)
			{
				string IdTipoDeComporbante = Convert.ToString(row["IdTipoDeComprobante"]);
				string IdCategoriaIVA = Convert.ToString(row["IdCategoriaIva"]);
				if(!_categoriaImpositivaTiposDeComprobantes.ContainsKey(IdCategoriaIVA))
					_categoriaImpositivaTiposDeComprobantes.Add(IdCategoriaIVA, new ArrayList());
				ArrayList aux = (ArrayList)_categoriaImpositivaTiposDeComprobantes[IdCategoriaIVA];
				aux.Add(IdTipoDeComporbante);
			}
		}

		ArrayList result = new ArrayList();
		if(_categoriaImpositivaTiposDeComprobantes.ContainsKey(unTipo))
			result = (ArrayList)_categoriaImpositivaTiposDeComprobantes[unTipo];
		else
			if(_categoriaImpositivaTiposDeComprobantes.ContainsKey("Default"))
				result = (ArrayList)_categoriaImpositivaTiposDeComprobantes[unTipo];
		return result;
	}
	
	public static string Momentos_Parametros( string unMomento, string unParametro )
	{
		return Variables.GetValueString( "Momentos."+unMomento+"."+unParametro);
	}

	public static string Momentos_Parametros(string processName, string taskName, string unParametro )
	{
		return Variables.GetValueString(processName, taskName, unParametro);
	}
	
	public static bool Momentos_Parametros_Bool( string unaTarea,string unProceso, string unParametro )
	{
		return Variables.GetValueBool( unProceso, unaTarea, unParametro);
	}

	public static bool Momentos_Parametros_Bool( string unaTarea,string unProceso, string unParametro, bool Default)
	{
		return Variables.GetValueBool( unProceso, unaTarea, unParametro, Default);
	}
	
	public static bool Momentos_Parametros_Bool( string unMomento, string unParametro )
	{
		return Variables.GetValueBool( "Momentos."+unMomento+"."+unParametro);
	}
	public static long Momento_De_Stock( string TipoComprobanteOrigen, string TipoComprobanteDestino)
	{
		return mz.erp.businessrules.tlg_TiposComprobantesOrigenDestino.GetMomento(TipoComprobanteOrigen, TipoComprobanteDestino);
	}
	/*public static void EstadosSegunMomento( long IdMomento, ref string EstadoOrigen, ref string EstadoDestino )
	{
		mz.erp.businessrules.Stock.GetEstados( IdMomento, ref EstadoOrigen, ref EstadoDestino );
	}*/

	public static bool Cuentas_CodigoAutomatico
	{
		get{return  Variables.GetValueBool("Cuentas.CodigoAutomatico");}

	}


    //German 20100426
    public static bool Producto_PermiteModificarCodigoManual
    {
        get { return Variables.GetValueBool("Productos.PermiteModificarCodigoManual"); }
    }
    //Fin German 20100426


	public static bool Producto_CodigoAutomatico
	{
		get{return Variables.GetValueBool("Productos.CodigoAutomatico");}
	}
	
	public static bool Proveedor_CodigoAutomatico
	{
		get{return Variables.GetValueBool("Proveedores.CodigoAutomatico");}
	}
	
	public static long Momentos_CondicionDeVenta_Default(string momento)
	{
		return Variables.GetValueLong("Momentos." + momento + ".CondicionDeVenta.Default");
	}
	public static long Momentos_CondicionDeVenta_Default(string Tarea, string Proceso)
	{
		return Variables.GetValueLong("Momentos." + Tarea + "." + Proceso + ".CondicionDeVenta.Default");
		/*
		long cond = Variables.GetValueLong("Momentos." + momento + ".CondicionDeVenta.Default");
		if(!cond.Equals(long.MinValue))
			return cond;
		return Variables.GetValueLong("Comprobantes.CondicionDeVenta.Default");
		*/
	}

	public static string  Momentos_Cuenta_Default(string momento)
	{
		return Variables.GetValueString("Momentos." + momento + ".Cuenta.Default");
	}

	public static bool ValidarComprobanteDePago( string momento)
	{
		return Variables.GetValueBool("Momentos."+ momento + ".Emision.Validar.CondVenta" );
	}
	
	public static string InstanciaCajaAbiertaDefault( string IdResponsable, string IdCaja )
	{
		return tfi_Cajas.GetInstanciaAbiertaDeCaja(IdResponsable,IdCaja);
	}
	
	public static string InstanciaCajaAbiertaDefault( string IdResponsable )
	{
		return tfi_Cajas.GetInstanciaAbiertaDeCaja(IdResponsable,Variables.GetValueString("Cajas.Default"));
	}
	
	public static string ComprobanteDePagoDefault()
	{
		return Variables.GetValueString("Comprobantes.ComprobantesDePago.Default");
	}


	public static string ComprobanteDePagoDefault(string momento)
	{
		return Variables.GetValueString("Momentos." + momento + ".ComprobantesDePago.Default");
	}


	public static int GetSignoComprobante( string IdTipoDeComprobante )
	{
		tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesRow row = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk( IdTipoDeComprobante );
		if (row != null)
		{
			return Convert.ToInt32( row.signo );
		}
		else
			return 1;

	}

	public static bool Comprobantes_CondicionDeVenta_Permite_Imputar(string IdCondicionDeVenta)
	{
		ArrayList ids = mz.erp.systemframework.Util.Parse(Variables.GetValueString("Comprobantes.CondicionesDeVentas.PermiteImputar"),",");
		return ids.Contains(IdCondicionDeVenta);
	}

	public static string Momentos_Cuenta_Domicilio_Default(string momento)
	{
		string idTipoDomicilio = Variables.GetValueString("Momentos." + momento + ".Cuenta.Domicilio.Default");
		if (idTipoDomicilio == string.Empty) 
		{
			idTipoDomicilio = Variables.GetValueString("Cuenta.Domicilio.Default");
		}		 
		return idTipoDomicilio;
	}	
	public static string[] Momentos_ComprobantesDeEntrega_Tareas_EstadosPrevios( string momento )
	{
		return Momentos_ComprobantesDeEntrega_Tareas_EstadosPrevios( momento, null );
	}

	public static string[] Momentos_ComprobantesDeEntrega_Tareas_EstadosPrevios( string momento, string tareaprevia )
	{
		string cadenatareaprevia;
		if (tareaprevia != null)
		{
			cadenatareaprevia = "."+tareaprevia;
		}
		else
		{
			cadenatareaprevia = string.Empty;
		}
		string estados = Variables.GetValueString( "Momentos."+momento+".TareasPrevias"+cadenatareaprevia+".EstadosPrevios");
		return estados.Split(new char[] { Convert.ToChar( "," ) }, 50 );
	}
	
	public static bool ValidarDomicilioEntregasMultipleSeleccion( string momento )
	{
		return Variables.GetValueBool( "Momentos."+momento+".Validar.DomicilioMultipleSeleccion" );
	}
	public static bool ValidarDomicilioEntregasSinSeleccion( string momento )
	{
		return Variables.GetValueBool( "Momentos."+momento+".Validar.DomicilioSinSeleccion" );
	}
	public static bool AdvertirDomicilioEntregasSinSeleccion( string momento )
	{
		return Variables.GetValueBool( "Momentos."+momento+".Advertir.DomicilioSinSeleccion" );
	}
	
	public static bool Momentos_Visualizar( string momento )
	{
		return !Variables.GetValueBool( "Momentos."+momento+".Emision.NoVisualizar");
	}

	public static bool Momentos_Visualizar( string NombreProceso, string NombreTarea )
	{
		return !Variables.GetValueBool( NombreProceso, NombreTarea, "Emision.NoVisualizar");
	}


	public static string[] Momentos_TareasAsociadas( string momento )
	{
		return Variables.GetValueString( "Momentos."+momento+".TareasAsociadas").Split(',');
	}

	public static string TareaProceso_GetDeposito(string processName, string taskName)
	{
		string IdVariable = "Momentos." + taskName + "." + processName + ".Deposito";
		string valor = Variables.GetValueString(IdVariable);
		if(!valor.Equals(string.Empty))
			return valor;
		else return Variables.GetValueString( "Momentos." + taskName + ".Deposito");

	}

	public static string TareaProceso_GetSeccion(string processName, string taskName)
	{
		string IdVariable = "Momentos." + taskName + "." + processName + ".Seccion";
		string valor = Variables.GetValueString(IdVariable);
		if(!valor.Equals(string.Empty))
			return valor;
		else return Variables.GetValueString( "Momentos." + taskName + ".Seccion");

	}

	public static bool Momentos_HabilitaGeneracionRapida(string processName, string taskName)
	{
		bool result = Variables.GetValueBool(processName, taskName, "HabilitaGeneracionRapida");
		if(!result)
			result = Variables.GetValueBool("Comprobantes.Seguridad.HabilitaGeneracionRapida");
		return result;
	}



    //German 20100908 - Tarea 825
    public static string Comprobantes_OrdenReparcion_IdProductoComodinServicios()
    {
        return Variables.GetValueString("Comprobantes.OrdenReparacion.AgruparTareas.IdProducto");
        
    }
    //Fin German 20100908 - Tarea 825

    
	
}

