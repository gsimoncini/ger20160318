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

	public class tcs_Tratamiento : IDisposable, IGridDocument
	{
		public tcs_Tratamiento()
		{
		}

		public tcs_Tratamiento( string[] fieldList )
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
			
			if ( fl.Contains( "IdTratamiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTratamiento", "IdTratamiento",true ) );
			if ( fl.Contains( "Abreviatura" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Abreviatura", "Abreviatura",250,Types.Aligment.Center,Types.FormatDisplay.Default ) );
			if ( fl.Contains( "Texto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Texto", "Texto",250,Types.Aligment.Center,Types.FormatDisplay.Default ) );
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
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tcs_Tratamiento.GetList().tcs_Tratamiento;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tcs_Tratamiento.Update( ( tcs_TratamientoDataset.tcs_TratamientoDataTable )dataTable );
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

		[ SearchMember( "tcs_Tratamiento" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdTratamiento" ) ] long IdTratamiento, 
			[ SearchParameterInfo( "Abreviatura" ) ] string Abreviatura, 
			[ SearchParameterInfo( "Texto" ) ] string Texto, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "IdReservado" ) ] long IdReservado, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa
			)
		{
			tcs_TratamientoDataset data = mz.erp.businessrules.tcs_Tratamiento.GetList( IdTratamiento, Abreviatura, Texto, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

