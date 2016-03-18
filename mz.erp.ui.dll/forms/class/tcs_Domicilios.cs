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

	public class tcs_Domicilios : IDisposable, IGridDocument
	{
		public tcs_Domicilios()
		{
		}

		public tcs_Domicilios( string[] fieldList )
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
			
			if ( fl.Contains( "IdDomicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdDomicilio", "IdDomicilio" , true) );
			if ( fl.Contains( "IdTipoDomicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDomicilio", "Tipo de Domicilio",115 ) );
			if ( fl.Contains( "Calle" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Calle", "Calle" , 100 ));
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero" , 70) );
			if ( fl.Contains( "Sector" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sector", "Sector", true ) );
			if ( fl.Contains( "Torre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Torre", "Torre", true ) );
			if ( fl.Contains( "Piso" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Piso", "Piso", true ) );
			if ( fl.Contains( "Departamento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Departamento", "Departamento" , true) );
			if ( fl.Contains( "Manzana" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Manzana", "Manzana", true ) );
			if ( fl.Contains( "CodigoPostal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoPostal", "CodigoPostal", true ) );
			if ( fl.Contains( "IdLocalidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdLocalidad", "Localidad" , 100) );
			if ( fl.Contains( "Partido" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Partido", "Partido", true ) );
			if ( fl.Contains( "IdProvincia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProvincia", "Provincia", true ) );
			if ( fl.Contains( "IdPais" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPais", "Pais", true ) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "Responsable" , true) );
			if ( fl.Contains( "Telefono" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Telefono", "Telefono", 200 ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion", true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" , true) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion", true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion", true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado", true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" , true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" , true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal", true ) );

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tcs_Domicilios.GetList().tcs_Domicilios;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tcs_Domicilios.Update( ( tcs_DomiciliosDataset.tcs_DomiciliosDataTable )dataTable );
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

		[ SearchMember( "tcs_Domicilios" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdDomicilio" ) ] string IdDomicilio, 
			[ SearchParameterInfo( "IdTipoDomicilio" ) ] long IdTipoDomicilio, 
			[ SearchParameterInfo( "Calle" ) ] string Calle, 
			[ SearchParameterInfo( "Numero" ) ] string Numero, 
			[ SearchParameterInfo( "IdLocalidad" ) ] string IdLocalidad, 
			[ SearchParameterInfo( "Partido" ) ] string Partido, 
			[ SearchParameterInfo( "IdProvincia" ) ] string IdProvincia, 
			[ SearchParameterInfo( "IdPais" ) ] string IdPais
			)
		{
			tcs_DomiciliosDataset data = mz.erp.businessrules.tcs_Domicilios.GetList( IdDomicilio, IdTipoDomicilio, Calle, Numero, IdLocalidad, Partido, IdProvincia, IdPais );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

