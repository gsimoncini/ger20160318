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

	public class sy_SentenciasReplicacion : IDisposable, IGridDocument
	{
		public sy_SentenciasReplicacion()
		{
		}

		public sy_SentenciasReplicacion( string[] fieldList )
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
			
			if ( fl.Contains( "IdSentenciaReplicacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSentenciaReplicacion", "IdSentenciaReplicacion" ) );
			if ( fl.Contains( "IdTabla" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTabla", "IdTabla" ) );
			if ( fl.Contains( "IdTipoSentencia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoSentencia", "IdTipoSentencia" ) );
			if ( fl.Contains( "Sentencia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sentencia", "Sentencia" ) );
			if ( fl.Contains( "SentenciaRowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SentenciaRowId", "SentenciaRowId" ) );
			if ( fl.Contains( "NombreArchivo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "NombreArchivo", "NombreArchivo" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdSucursalGeneradora" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursalGeneradora", "IdSucursalGeneradora" ) );
			if ( fl.Contains( "IdConexion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexion", "IdConexion" ) );
			if ( fl.Contains( "Destino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Destino", "Destino" ) );
			if ( fl.Contains( "VersionBD" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "VersionBD", "VersionBD" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_SentenciasReplicacion.GetList().sy_SentenciasReplicacion;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_SentenciasReplicacion.Update( ( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionDataTable )dataTable );
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

		[ SearchMember( "sy_SentenciasReplicacion" ) ]
		public static DataSet GetList( string nada )
		{
			sy_SentenciasReplicacionDataset data = mz.erp.businessrules.sy_SentenciasReplicacion.GetList(  );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

