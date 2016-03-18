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

	public class tcs_TiposDomicilios : IDisposable, IGridDocument
	{
		public tcs_TiposDomicilios()
		{
		}

		public tcs_TiposDomicilios( string[] fieldList )
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
			
			if ( fl.Contains( "IdTipoDomicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDomicilio", "IdTipoDomicilio",true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 250,Types.Aligment.Center,Types.FormatDisplay.Default) );
			if ( fl.Contains( "Sistema" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sistema", "Sistema",true ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ,true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		[ValueListGridMember]
		public DataTable GetList()
		{
			return mz.erp.businessrules.tcs_TiposDomicilios.GetList().tcs_TiposDomicilios;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tcs_TiposDomicilios.Update( ( tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosDataTable )dataTable );
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

		[ SearchMember( "tcs_TiposDomicilios" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdTipoDomicilio" ) ] long IdTipoDomicilio, 
			[ SearchParameterInfo( "Descripcion" ) ] string Descripcion, 
			[ SearchParameterInfo( "Sistema" ) ] bool Sistema, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "IdReservado" ) ] long IdReservado, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa
			)
		{
			tcs_TiposDomiciliosDataset data = mz.erp.businessrules.tcs_TiposDomicilios.GetList( IdTipoDomicilio, Descripcion, Sistema, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

