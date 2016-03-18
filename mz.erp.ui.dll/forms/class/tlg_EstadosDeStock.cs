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

	public class tlg_EstadosDeStock : IDisposable, IGridDocument
	{
		public tlg_EstadosDeStock()
		{
		}

		public tlg_EstadosDeStock( string[] fieldList )
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
			
			if ( fl.Contains( "IdEstadoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEstadoDeStock", "IdEstadoDeStock", true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			/*if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion", true) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa", true) );
			if ( fl.Contains( "OldIdEstadoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "OldIdEstadoDeStock", "OldIdEstadoDeStock",true ) );
			*/
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		[ SearchMember( "tlg_EstadosDeStock" ) ]
		public static DataSet GetList( 
			[ SearchParameterInfo( "IdEstadoDeStock", IsAlternativePrimaryKey = true ) ] string IdEstadoDeStock,
			[ SearchParameterInfo( "Descripcion", IsDescription = true  ) ] string Descripcion
			)
		{
			tlg_EstadosDeStockDataset data = mz.erp.businessrules.tlg_EstadosDeStock.GetList( IdEstadoDeStock, Descripcion );
			return ( DataSet )data;
		}
		[ValueListGridMember]
		public DataTable GetList()
		{
			return mz.erp.businessrules.tlg_EstadosDeStock.GetList().tlg_EstadosDeStock;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tlg_EstadosDeStock.Update( ( tlg_EstadosDeStockDataset.tlg_EstadosDeStockDataTable )dataTable );
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

		/*[ SearchMember( "tlg_EstadosDeStock" ) ]
		public static DataSet GetList(  )
		{
			tlg_EstadosDeStockDataset data = mz.erp.businessrules.tlg_EstadosDeStock.GetList(  );
			return ( DataSet )data;
		}*/
		
		public void Dispose()
		{
		}
		
	}
}

