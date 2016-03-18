using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;

namespace mz.erp.ui.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeArtDesacConStock.
	/// </summary>
	public class rep_ListadoDeArtDesacConStock
	{
		public rep_ListadoDeArtDesacConStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList()
		{			
			return mz.erp.businessrules.reportes.rep_ListadoDeArtDesacConStock.GetList( Security.IdEmpresa, Security.IdSucursal);
		}

		
		private static string[] _fieldList=null;
		
		[ atMethodLayoutData ]
		public static string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			//estos son los campos q se van a mostrar en la grilla
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "IdTipoProducto",true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",false) );
			if ( fl.Contains( "CodigoSecundario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoSecundario", "CodigoSecundario",true) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",400, true) );
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "DescripcionCorta",true) );
			if ( fl.Contains( "DescripcionLarga" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionLarga", "Descripción",500, false) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad",false) );
			if ( fl.Contains( "UnidadesPedido" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UnidadesPedido", "Unidades",true) );
			if ( fl.Contains( "MAC" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MAC", "MAC",true) );
			if ( fl.Contains( "PrecioDeCostoRef" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoRef", "PrecioDeCostoRef",true) );
			if ( fl.Contains( "PrecioDeVentaNeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaNeto", "PrecioDeVentaNeto",true) );
			if ( fl.Contains( "MaxDescuentoPorcentual" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MaxDescuentoPorcentual", "MaxDescuentoPorcentual",true) );
			if ( fl.Contains( "MaxDescuento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MaxDescuento", "MaxDescuento",true) );
			if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "PrecioDeVentaBruto",true) );
			if ( fl.Contains( "ObligaCodigoBarra" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ObligaCodigoBarra", "ObligaCodigoBarra",true) );
			if ( fl.Contains( "ObligaNumeroSerie" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ObligaNumeroSerie", "ObligaNumeroSerie",true) );
			if ( fl.Contains( "IdBonificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdBonificacion", "IdBonificacion",true) );
			if ( fl.Contains( "IdCuentaImputacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuentaImputacion", "IdCuentaImputacion",true) );
			if ( fl.Contains( "FechaUltimaCompra" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true) );
			if ( fl.Contains( "IdUnidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdUnidad", "IdUnidad",true) );
			if ( fl.Contains( "IdConversion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true) );
			if ( fl.Contains( "CampoAuxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", "CampoAuxiliar1",true) );
			if ( fl.Contains( "CampoAuxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", "CampoAuxiliar2",true) );
			if ( fl.Contains( "CampoAuxiliar3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", "CampoAuxiliar3",true) );
			if ( fl.Contains( "CampoAuxiliar4" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar4", "CampoAuxiliar4",true) );
			if ( fl.Contains( "CampoAuxiliar5" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar5", "CampoAuxiliar5",true) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",true) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true) );
			

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();	
		}

	}
}
