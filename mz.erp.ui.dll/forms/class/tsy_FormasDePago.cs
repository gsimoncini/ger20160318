namespace mz.erp.ui
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;

	public class tsy_FormasDePago : IDisposable, IGridDocument
	{
		public tsy_FormasDePago()
		{
		}

		public tsy_FormasDePago( string[] fieldList )
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
			
			if ( fl.Contains( "IdFormaDePago" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdFormaDePago", "IdFormaDePago" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo" ) );
			if ( fl.Contains( "Sistema" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sistema", "Sistema" ) );
			if ( fl.Contains( "MaximoPorcentaje" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MaximoPorcentaje", "MaximoPorcentaje" ) );
			if ( fl.Contains( "MaximoMontoFijo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MaximoMontoFijo", "MaximoMontoFijo" ) );
			if ( fl.Contains( "IdTasaDeCambio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTasaDeCambio", "IdTasaDeCambio" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsy_FormasDePago.GetList().tsy_FormasDePago;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsy_FormasDePago.Update( ( tsy_FormasDePagoDataset.tsy_FormasDePagoDataTable )dataTable );
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

		[ SearchMember( "tsy_FormasDePago" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdFormaDePago" ) ] string IdFormaDePago, 
			[ SearchParameterInfo( "Descripcion" ) ] string Descripcion, 
			[ SearchParameterInfo( "Activo" ) ] bool Activo, 
			[ SearchParameterInfo( "Sistema" ) ] bool Sistema, 
			[ SearchParameterInfo( "MaximoPorcentaje" ) ] decimal MaximoPorcentaje, 
			[ SearchParameterInfo( "MaximoMontoFijo" ) ] decimal MaximoMontoFijo, 
			[ SearchParameterInfo( "IdTasaDeCambio" ) ] long IdTasaDeCambio, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "IdReservado" ) ] long IdReservado, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa
			)
		{
			tsy_FormasDePagoDataset data = mz.erp.businessrules.tsy_FormasDePago.GetList( IdFormaDePago, Descripcion, Activo, Sistema, MaximoPorcentaje, MaximoMontoFijo, IdTasaDeCambio, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

