using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;
using mz.erp.businessrules.reportes;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;

namespace mz.erp.ui.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeMovimientosDeStock.
	/// </summary>
	public class rep_ListadoDeMovimientosDeStock
	{
		public rep_ListadoDeMovimientosDeStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		[ atMethodReportRefreshData ]
        //Cristian Tarea 0000010 20110224
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta , string Persona, string Producto, string TipoDeAjuste, string Deposito, string Seccion)
		{			
			return mz.erp.businessrules.reportes.rep_ListadoDeMoviemientosDeStock.GetList(FechaDesde, FechaHasta, Persona, Producto, TipoDeAjuste, Deposito, Seccion, Security.IdEmpresa, Security.IdSucursal);
		}
        //fin Cristian
		
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

			//estos son los campos q se vana  mostrar en la grilla
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha",false) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad",false) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",false) );
			if ( fl.Contains( "CodigoSecundario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoSecundario", "Cod. Sec",100) );
			if ( fl.Contains( "Producto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Producto",false) );
			if ( fl.Contains( "Deposito" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Deposito", "Depósito",false) );
			if ( fl.Contains( "Ubicacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ubicacion", "Ubicación",false) );
			if ( fl.Contains( "Seccion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Seccion", "Sección",false) );
			if ( fl.Contains( "EstadoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "EstadoDeStock", "Estado de Stock",false) );
			if ( fl.Contains( "TipoDeAjuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TipoDeAjuste", "Tipo de Ajuste",false) );
			if ( fl.Contains( "Usuario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Usuario", "Responsable",false) );
			if ( fl.Contains( "Perfil" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Perfil", "Perfil",true) );
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			if ( fl.Contains( "IdDeposito" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdDeposito", "IdDeposito",true) );
			if ( fl.Contains( "IdSeccion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSeccion", "IdSeccion",true) );
			if ( fl.Contains( "IdEstadoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEstadoDeStock", "IdEstadoDeStock",true) );
			if ( fl.Contains( "IdTipoDeAjuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeAjuste", "IdTipoDeAjuste",true) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true) );
			if ( fl.Contains( "IdConexion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexion", "IdConexion",true) );
			if ( fl.Contains( "IdUsuario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdUsuario", "IdUsuario",true) );	
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();	
		}
	}
}
