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

	public class sy_Sucursales : IDisposable, IGridDocument
	{
		public sy_Sucursales()
		{
		}

		public sy_Sucursales( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		
		
		
		
		[atMethodLayoutData]
		
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
			
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",200,Types.Aligment.Center ) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "IdResponsable",true ) );
			if ( fl.Contains( "Direccion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Direccion", "Direccion",150,Types.Aligment.Center ) );
			if ( fl.Contains( "IdLocalidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdLocalidad", "IdLocalidad",true ) );
			if ( fl.Contains( "CargoFijoProductos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CargoFijoProductos", "Cargo Fijo Productos",150,Types.Aligment.Far,Types.FormatDisplay.Percent) );
			if ( fl.Contains( "BonificacionRecargoProductos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "BonificacionRecargoProductos", "Bonificacion Recargo Productos",150,Types.Aligment.Far,Types.FormatDisplay.Percent ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_Sucursales.GetList().sy_Sucursales;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Sucursales.Update( ( sy_SucursalesDataset.sy_SucursalesDataTable )dataTable );
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

		[ SearchMember( "sy_Sucursales" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdSucursal", IsAlternativePrimaryKey = true ) ] long IdSucursal, 
			[ SearchParameterInfo( "Descripcion", IsDescription = true ) ] string Descripcion, 
			[ SearchParameterInfo( "Direccion" ) ] string Direccion
			)
		{
			sy_SucursalesDataset data = mz.erp.businessrules.sy_Sucursales.GetList( IdSucursal, Descripcion, Direccion );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

