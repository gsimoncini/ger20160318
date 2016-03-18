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

	public class tsy_CategoriasIva : IDisposable, IGridDocument
	{
		public tsy_CategoriasIva()
		{
		}

		public tsy_CategoriasIva( string[] fieldList )
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
			
			if ( fl.Contains( "IdCategoriaIva" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCategoriaIva", "Id de Categoria Iva",150 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",200 ) );
			if ( fl.Contains( "ActivoVentas" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ActivoVentas", "ActivoVentas",true ) );
			if ( fl.Contains( "ActivoCompras" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ActivoCompras", "ActivoCompras",true ) );
			if ( fl.Contains( "Clase" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Clase", "Clase",true ) );
			if ( fl.Contains( "PuertoImpresora" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PuertoImpresora", "PuertoImpresora",true ) );
			if ( fl.Contains( "Copias" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Copias", "Copias",true ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion", true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		[atMethodLayoutData]
		public static  string GetLayoutData()
		{
			string [] _fieldList = null;
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdCategoriaIva" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCategoriaIva", "Id de Categoria Iva",150 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",200 ) );
			if ( fl.Contains( "ActivoVentas" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ActivoVentas", "ActivoVentas",true ) );
			if ( fl.Contains( "ActivoCompras" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ActivoCompras", "ActivoCompras",true ) );
			if ( fl.Contains( "Clase" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Clase", "Clase",true ) );
			if ( fl.Contains( "PuertoImpresora" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PuertoImpresora", "PuertoImpresora",true ) );
			if ( fl.Contains( "Copias" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Copias", "Copias",true ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion", true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsy_CategoriasIva.GetList().tsy_CategoriasIva;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsy_CategoriasIva.Update( ( tsy_CategoriasIvaDataset.tsy_CategoriasIvaDataTable )dataTable );
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

		[ SearchMember( "tsy_CategoriasIva" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "Codigo" ,IsAlternativePrimaryKey = true) ] string IdCategoriaIva, 
			[ SearchParameterInfo( "Descripcion", IsDescription= true ) ] string Descripcion
			)
		{
			tsy_CategoriasIvaDataset data = mz.erp.businessrules.tsy_CategoriasIva.GetList( IdCategoriaIva, Descripcion );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

