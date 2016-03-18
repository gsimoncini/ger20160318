namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;
	using mz.erp.ui.controllers;

	public class tpr_ObjetosCuentas : IDisposable, IGridDocument
	{
		public tpr_ObjetosCuentas()
		{
		}

		public tpr_ObjetosCuentas( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		
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
			
			if ( fl.Contains( "IdObjeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdObjeto", "IdObjeto", true ) );
			if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta", true ) );
			if ( fl.Contains( "NumeroDeSerie" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "NumeroDeSerie", "Nro. de Serie", 50 ) );
			if ( fl.Contains( "CodigoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoProducto", "Cod.Prod", 30 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Producto", 100 ) );
			if ( fl.Contains( "CodigoCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoCuenta", "Cod.Cuenta", 20 ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cuenta", 50 ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpr_ObjetosCuentas.GetList().tpr_ObjetosCuentas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpr_ObjetosCuentas.Update( ( tpr_ObjetosCuentasDataset.tpr_ObjetosCuentasDataTable )dataTable );
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

		[ SearchMember( "tpr_ObjetosCuentas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdObjeto" ) ] string IdObjeto, 
			[ SearchParameterInfo( "IdCuenta" ) ] string IdCuenta
			)
		{
			tpr_ObjetosCuentasDataset data = mz.erp.businessrules.tpr_ObjetosCuentas.GetList( IdObjeto, IdCuenta );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

