namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
	using System.Drawing;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;
	using mz.erp.businessrules;
	using mz.erp.ui.controllers;

	public class tsh_Productos : IDisposable, IGridDocument
	{
		public tsh_Productos()
		{
		}

		public tsh_Productos( string[] fieldList )
		{
			_fieldList = fieldList;
		}





		[ atMethodLayoutData ]
		public string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			string etiquetaCampoAuxiliar1 = Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta");
			string etiquetaCampoAuxiliar2 = Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta");
			string etiquetaCampoAuxiliar3 = Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta");
			string etiquetaCampoAuxiliar4 = Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta");
			string etiquetaCampoAuxiliar5 = Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta");			
			//string etiquetaCodigoSecundario = Variables.GetValueString("Productos.CodigoSecundario.Etiqueta");

			bool HideCampoAux1 = etiquetaCampoAuxiliar1.Trim() == "" ? true : false;
			bool HideCampoAux2 = etiquetaCampoAuxiliar2.Trim() == "" ? true : false;
			bool HideCampoAux3 = etiquetaCampoAuxiliar3.Trim() == "" ? true : false;
			bool HideCampoAux4 = etiquetaCampoAuxiliar4.Trim() == "" ? true : false;
			bool HideCampoAux5 = etiquetaCampoAuxiliar5.Trim() == "" ? true : false;

            /* Silvina 20100102 - Tarea 904 */

            if (fl.Contains("IdProducto") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdProducto", "IdProducto", true));
            if (fl.Contains("IdTipoProducto") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdTipoProducto", "Tipo de Producto", true));
            if (fl.Contains("DescripcionCorta") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "DescripcionCorta", "Descripcion Corta", true));
            if (fl.Contains("DescripcionLarga") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "DescripcionLarga", "Descripcion Larga", true));
            if (fl.Contains("StockAntesMinimo") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "StockAntesMinimo", "StockAntesMinimo", true));

            string campos = Variables.GetValueString("Productos.ListaColumnasVisibles");
            ArrayList listaCampos = mz.erp.systemframework.Util.Parse(campos);

            foreach (string campo in listaCampos)
            {
                if (campo.Equals("Codigo"))
                    if (fl.Contains("Codigo") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Codigo", "Codigo", 50));
                /*if ( fl.Contains( "CodigoSecundario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoSecundario", "Codigo Secundario",150 ) );*/
                if (campo.Equals("Descripcion"))
                    if (fl.Contains("Descripcion") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Descripcion", "Descripcion", 250));
                if (campo.Equals("PrecioFinalEstimado"))
                    if (fl.Contains("PrecioFinalEstimado") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "PrecioFinalEstimado", "Precio", 65, Types.Aligment.Far, Types.FormatDisplay.Money));
                if (campo.Equals("StockDisponible"))
                    if (fl.Contains("StockDisponible") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "StockDisponible", "Stock", 65, Types.Aligment.Far, Types.FormatDisplay.Integer));

                if (campo.Equals("CampoAuxiliar1"))
                    if (fl.Contains("CampoAuxiliar1") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "CampoAuxiliar1", etiquetaCampoAuxiliar1, 65, HideCampoAux1));
                if (campo.Equals("CampoAuxiliar2"))
                    if (fl.Contains("CampoAuxiliar2") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "CampoAuxiliar2", etiquetaCampoAuxiliar2, 65, HideCampoAux2));
                if (campo.Equals("CampoAuxiliar3"))
                    if (fl.Contains("CampoAuxiliar3") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "CampoAuxiliar3", etiquetaCampoAuxiliar3, 65, HideCampoAux3));
                if (campo.Equals("CampoAuxiliar4"))
                    if (fl.Contains("CampoAuxiliar4") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "CampoAuxiliar4", etiquetaCampoAuxiliar4, 65, HideCampoAux4));
                if (campo.Equals("CampoAuxiliar5"))
                    if (fl.Contains("CampoAuxiliar5") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "CampoAuxiliar5", etiquetaCampoAuxiliar5, 65, HideCampoAux5));

                /*if ( fl.Contains( "UnidadesPedido" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UnidadesPedido", "Unidades por Pedido",150, true ) );
                if ( fl.Contains( "MAC" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MAC", "MAC",150,true ) );
                if ( fl.Contains( "PrecioDeCostoRef" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoRef", "Precio De Costo Referencia",200,true ) );
                if ( fl.Contains( "PrecioDeVentaNeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaNeto", "Precio De Venta Neto", 200,true ) );
                if ( fl.Contains( "MaxDescuentoPorcentual" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MaxDescuentoPorcentual", "Maximo Descuento Porcentual",200,true ) );
                if ( fl.Contains( "MaxDescuento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MaxDescuento", "Maximo Descuento",200,true ) );
                if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Precio De Venta Bruto", 200,true ) );
                if ( fl.Contains( "ObligaCodigoBarra" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ObligaCodigoBarra", "Obliga Codigo de Barra", 200,true ) );
                if ( fl.Contains( "ObligaNumeroSerie" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ObligaNumeroSerie", "Obliga Numero de Serie", 200,true ) );
                if ( fl.Contains( "IdCuentaImputacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuentaImputacion", "Cuenta de Imputacion",200,true ) );
                if ( fl.Contains( "FechaUltimaCompra" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaUltimaCompra", "Fecha de Ultima Compra", 200,true ) );
                if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo", 100,true ) );
                if ( fl.Contains( "IdBonificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdBonificacion", "Bonificacion", 150, true ) );*/
                
                if (campo.Equals("FechaUltimaModificacionPrecioDeCosto"))
                    if (fl.Contains("FechaUltimaModificacionPrecioDeCosto") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "FechaUltimaModificacionPrecioDeCosto", "F. Ult. Mod. P. Costo", 100, Types.Aligment.Far, Types.FormatDisplay.DateTimeShort));
                /* Silvina 20101119 - Tarea 952 */
                if (campo.Equals("MonedaOrigenPCosto"))
                    if (fl.Contains("MonedaOrigenPCosto") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "MonedaOrigenPCosto", "Moneda P.Costo", 60));
                if (campo.Equals("PrecioDeCostoRefMonedaDestino"))
                    if (fl.Contains("PrecioDeCostoRefMonedaDestino") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "PrecioDeCostoRefMonedaDestino", "P. Costo M.Ref.", 65, Types.Aligment.Far, Types.FormatDisplay.Money));
                if (campo.Equals("SimboloMonedaOrigenPrecioDeVentaNeto"))
                    if (fl.Contains("SimboloMonedaOrigenPrecioDeVentaNeto") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "SimboloMonedaOrigenPrecioDeVentaNeto", "Moneda P.Venta", 60));
                if (campo.Equals("SimboloMonedaDestino"))
                    if (fl.Contains("SimboloMonedaDestino") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "SimboloMonedaDestino", "Moneda Ref.", 60));
                if (campo.Equals("PrecioDeCostoRef"))
                    if (fl.Contains("PrecioDeCostoRef") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "PrecioDeCostoRef", "P. Costo", 65, Types.Aligment.Far, Types.FormatDisplay.Money));
                if (campo.Equals("PrecioFinalEstimadoMonedaDestino"))
                    if (fl.Contains("PrecioFinalEstimadoMonedaDestino") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "PrecioFinalEstimadoMonedaDestino", "P. Venta M.Ref.", 65, Types.Aligment.Far, Types.FormatDisplay.Money));
                /* Fin Silvina */
                /* Silvina 20110630 - Tarea 0000136 */
                if (campo.Equals("PermiteCambio"))
                    if (fl.Contains("PermiteCambio") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "PermiteCambio", "P/Cambio", 65, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox));
                /* Fin Silvina 20110630 - Tarea 0000136 */
            }

            /* Fin Silvina */

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public string GetLayoutProductos()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "Tipo de Producto",true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",true) );
			
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",400) );
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Descripcion Corta",true ) );
			if ( fl.Contains( "DescripcionLarga" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionLarga", "Descripcion Larga", true ) );
			if ( fl.Contains( "CodigoSecundario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoSecundario", "Codigo Secundario",150 ) );

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_Productos.GetList().tsh_Productos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_Productos.Update( ( tsh_ProductosDataset.tsh_ProductosDataTable )dataTable );
		}
		
		private string[] _fieldList;
		public string[] FieldList
		{
			get
			{
				return _fieldList;
			}
			set
			{
				_fieldList = value;
			}
		}

		[ SearchMember( "tsh_Productos" , Caption ="Productos", OrderUIAvailable = true) ]
		public static DataSet GetList(
            //Cristian Tarea 0000192 20110811
			[ SearchParameterInfo( "Codigo", IsAlternativePrimaryKey = true, OrderUI = 1 ,MiddleSize=true) ] string Codigo, 
			[ SearchParameterInfo( "Descripcion", IsDescription = true, OrderUI = 3) ] string Descripcion,
            [SearchParameterInfo("Codigo Secundario", OrderUI = 2, CaptionVariable = "Productos.CodigoSecundario.Etiqueta", MiddleSize = true)] string CodigoSecundario ,
            //Fin Cristian Tarea 0000192
            //Cristian Tarea 0000027 20110218
            //[ SearchParameterInfo( "Tipo de Producto", OrderUI = 6) ] string IdTipoProducto,
            [SearchParameterInfo("Stock", IsSearch = false, Metodo = "GetCadenaStocks", OrderUI = 4, MiddleSize = true)] string Stock,
            //German 20120131 - Tarea 0000268 - Se agrega el IsSearch
			[ SearchParameterInfo( "Campos auxiliares", IsSearch = false, Metodo = "GetCamposAuxiliares", OrderUI = 5) ] string CamposAuxiliares,
            //Fin German 20120131 - Tarea 0000268
			[ SearchParameterInfo( "Activo", OrderUI = 7 , MiddleSize= true) ] bool Activo
            //Fin Cristian
            /* Silvina 20110704 - Tarea 0000136 */
           , [SearchParameterInfo("P/Cambio", OrderUI = 6,MiddleSize = true, Checked = false)] bool PermiteCambio
            /* Fin Silvina 20110704 - Tarea 0000136 */
			)
		{
			tsh_ProductosDataset data ;

            if (Variables.GetValueBool("Productos.Busquedas.BusquedaParcial"))
                /* Silvina 20110704 - Tarea 0000136 */
                data = mz.erp.businessrules.tsh_Productos.GetList( null, Codigo, CodigoSecundario, Descripcion, null, null, Activo, PermiteCambio );
                //data = null;// mz.erp.businessrules.tsh_Productos.GetList(null, Codigo, CodigoSecundario, Descripcion, null, null, Activo);
            /* Fin Silvina 20110704 - Tarea 0000136 */
                //data = mz.erp.businessrules.tsh_Productos.GetList(null, Codigo, CodigoSecundario, Descripcion, null, null, null);
            else
                //data = mz.erp.businessrules.tsh_Productos.GetListEx( IdTipoProducto, Codigo, CodigoSecundario, Descripcion, null, null, Activo );			
                /* Silvina 20110704 - Tarea 0000136 */
                data = mz.erp.businessrules.tsh_Productos.GetListEx( null, Codigo, CodigoSecundario, Descripcion, null, null, Activo, PermiteCambio );
            //data = null;//mz.erp.businessrules.tsh_Productos.GetListEx(null, Codigo, CodigoSecundario, Descripcion, null, null, Activo);
                /* Fin Silvina 20110704 - Tarea 0000136 */
            return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}

		[HierarchicalSearchMember(typeof (mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd))]
		public static DataTable HierarchicalSearch(string jerarquia)	
		{
			System.Data.DataTable tabla = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquia(jerarquia, Security.IdSucursal, Security.IdEmpresa);
			return tabla;
		}

		/*public static DataTable HierarchicalSearch(string jerarquia, bool activo)	
		{
			System.Data.DataTable tabla = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquia(jerarquia, Security.IdSucursal, Security.IdEmpresa, activo);
			return tabla;
		}*/

		public static string GetCadenaStocks(string codigo) 
		{			
			/*
			string IdProducto = businessrules.tsh_Productos.GetPkByCodigo(codigo);
			string IdVisualizacionDeStock = Variables.GetValue("Stock.VisualizacionDeStock.Default").ToString();
			string IdEstadoDeStock = Variables.GetValue("Stock.EstadoDeStock.Default").ToString();				

			DataSet data = businessrules.Productos.GetStockSucursal(IdProducto, IdVisualizacionDeStock, IdEstadoDeStock);
			
			try 
			{
				string cadena = "";
				for (int i = 0; i < data.Tables[0].Rows.Count; i++) 
				{
					string sucursal = data.Tables[0].Rows[i]["Sucursal"].ToString();
					decimal DecStock = Convert.ToDecimal(data.Tables[0].Rows[i]["Cantidad"]);
					string stock = decimal.Round(DecStock,0).ToString();
					cadena = cadena + sucursal + ": " + stock + " ; ";
				}							
				return cadena;
			}
			catch (Exception e) 
			{
				return "";
			}	
			*/
			return string.Empty;
		}		

		public static string GetCamposAuxiliares(string codigo) 
		{			
			string IdProducto = businessrules.tsh_Productos.GetPkByCodigo(codigo);
			Productos pro = new Productos(IdProducto);
			/*pro.NombreCampoAuxiliar1 = Variables.GetValue("Productos.CampoAuxiliar1.Etiqueta").ToString();
			pro.NombreCampoAuxiliar2 = Variables.GetValue("Productos.CampoAuxiliar2.Etiqueta").ToString();
			pro.NombreCampoAuxiliar3 = Variables.GetValue("Productos.CampoAuxiliar3.Etiqueta").ToString();
			pro.NombreCampoAuxiliar4 = Variables.GetValue("Productos.CampoAuxiliar4.Etiqueta").ToString();
			pro.NombreCampoAuxiliar5 = Variables.GetValue("Productos.CampoAuxiliar5.Etiqueta").ToString();*/
			
			string cadena = "";
			if (pro.CampoAuxiliar1.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar1 + ": " + pro.CampoAuxiliar1 + " ; ";}
			if (pro.CampoAuxiliar2.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar2 + ": " + pro.CampoAuxiliar2 + " ; ";}
			if (pro.CampoAuxiliar3.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar3 + ": " + pro.CampoAuxiliar3 + " ; ";}
			if (pro.CampoAuxiliar4.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar4 + ": " + pro.CampoAuxiliar4 + " ; ";}
			if (pro.CampoAuxiliar5.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar5 + ": " + pro.CampoAuxiliar5 + " ; ";}
			
			return cadena;
		}
	
		[ atAllowMultipleRows ]
		public static bool AllowMultipleSelect
		{
			get { return (false); }
		}
		[ atHierarchicalSearch ]
		public static bool AllowBusquedaJerarquica
		{
			get 
			{
				return Variables.GetValueBool("Productos.Comprobantes.BusquedaJerarquica"); 
			}
		}
		
		[ atOrderBy ]
		public static string DefaultOrderBy
		{
			get
			{
				return Variables.GetValueString("Productos.Busquedas.OrderBy");
			}
		}

		[ atFormatCondition ]
		public static FormatoCondicional Formato 
		{
			get
			{
				bool Visible = Variables.GetValueBool("Productos.StockInferiorMinimo.Visible");
				string Campo = Variables.GetValueString("Productos.StockInferiorMinimo.NombreCampo");
				string Condicion = Variables.GetValueString("Productos.StockInferiorMinimo.Condicion");
				string Valor = Variables.GetValueString("Productos.StockInferiorMinimo.Valor");
				string ColorStr = Variables.GetValueString("Productos.StockInferiorMinimo.Color");
                System.Drawing.Color Color = System.Drawing.Color.FromName(ColorStr);				
				return new FormatoCondicional(Visible, Campo, Condicion, Valor, Color);
			}
		}

		[ atFastSearch ]
		public static bool AllowFastSearch
		{
			get
			{
				return Variables.GetValueBool("Productos.Busquedas.FastSearch");
			}
		}


        //Matias 20100716 - Tarea 85
        [atOrdenarPor]
        public static string OrdenarPor
        {
            get
            {
                return Variables.GetValueString("Productos.Busquedas.OrdenarPor");
            }
        }
        //Fin Matias 20100716 - Tarea 85
			

	
	}
}

