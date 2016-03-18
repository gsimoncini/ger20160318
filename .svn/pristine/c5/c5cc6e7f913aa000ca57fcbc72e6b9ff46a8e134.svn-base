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

	public class sy_Excepciones : IDisposable
	{
		public sy_Excepciones()
		{
		}

		public sy_Excepciones( string[] fieldList )
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
			
			if ( fl.Contains( "IdExcepcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdExcepcion", "IdExcepcion" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "Machine" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Machine", "Machine" ) );
			if ( fl.Contains( "User" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "User", "User" ) );
			if ( fl.Contains( "Version" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Version", "Version" ) );
			if ( fl.Contains( "AppDomain" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "AppDomain", "AppDomain" ) );
			if ( fl.Contains( "CodeBase" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodeBase", "CodeBase" ) );
			if ( fl.Contains( "Exc_Source" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Exc_Source", "Exc_Source" ) );
			if ( fl.Contains( "Exc_Type" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Exc_Type", "Exc_Type" ) );
			if ( fl.Contains( "Exc_Message" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Exc_Message", "Exc_Message" ) );
			if ( fl.Contains( "Exc_Site" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Exc_Site", "Exc_Site" ) );
			if ( fl.Contains( "Exc_StackTrace" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Exc_StackTrace", "Exc_StackTrace" ) );
			if ( fl.Contains( "Exc_InnerException" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Exc_InnerException", "Exc_InnerException" ) );
			if ( fl.Contains( "Exc_HelpLink" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Exc_HelpLink", "Exc_HelpLink" ) );
			if ( fl.Contains( "Exception" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Exception", "Exception" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_Excepciones.GetList().sy_Excepciones;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Excepciones.Update( ( sy_ExcepcionesDataset.sy_ExcepcionesDataTable )dataTable );
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
		/*[ SearchMember( "sy_Excepciones" ) ]
		public static DataSet GetList(  )
		{
			sy_ExcepcionesDataset data = mz.erp.businessrules.sy_Excepciones.GetList(  );
			return ( DataSet )data;
		}*/

		
		public void Dispose()
		{
		}
		
	}
}

