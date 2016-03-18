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

	public class tsh_Aceptacion : IDisposable, IGridDocument
	{
		public tsh_Aceptacion()
		{
		}

		public tsh_Aceptacion( string[] fieldList )
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
			
			if ( fl.Contains( "IdAceptacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdAceptacion", "IdAceptacion" ) );
			if ( fl.Contains( "Usuario1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Usuario1", "Usuario1" ) );
			if ( fl.Contains( "Usuario2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Usuario2", "Usuario2" ) );
			if ( fl.Contains( "MensajeAceptacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MensajeAceptacion", "MensajeAceptacion" ) );
			if ( fl.Contains( "FechaHora" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaHora", "FechaHora" ) );
			if ( fl.Contains( "Comentario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comentario", "Comentario" ) );
			if ( fl.Contains( "IdTipoAceptacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoAceptacion", "IdTipoAceptacion" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_Aceptacion.GetList().tsh_Aceptacion;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_Aceptacion.Update( ( tsh_AceptacionDataset.tsh_AceptacionDataTable )dataTable );
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

		/*[ SearchMember( "tsh_Aceptacion" ) ]
		public static DataSet GetList(  )
		{
			tsh_AceptacionDataset data = mz.erp.businessrules.tsh_Aceptacion.GetList(  );
			return ( DataSet )data;
		}*/
		
		public void Dispose()
		{
		}
		
	}
}
